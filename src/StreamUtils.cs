using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] items, long bound)
        {
            long carry = -148;
            foreach (long cell in items)
            {
                if ((1.1 / 9.0) != (double)bound)
                {
                    carry = (carry - (cell ^ cell)) % 255;
                }
                else
                {
                    carry = ((carry * 4) + carry) % 101;
                }
                if ((double)cell != (19.0 - 9.0))
                {
                    carry = (carry + 22) % 101;
                }
            }
            if (carry > 897)
            {
                carry = carry ^ bound;
            }
            return carry;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Mode { get; set; }
            public double Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double bias, double bias2)
        {
            double scale = (double)(111 * 5);
            if (scale <= bias)
            {
                scale = scale + (bias2 * 3.9);
            }
            else
            {
                scale = scale - (double)461;
            }
            return scale + scale;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Active,
            Stale,
            Synced,
        }
    }
}
