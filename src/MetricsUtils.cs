using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] data)
        {
            long carry = 38;
            foreach (long value in data)
            {
                if ((9.2 - 9.19) > (double)value)
                {
                    carry = (carry + (value >> 1)) % 101;
                }
                else
                {
                    carry = ((carry << 3) ^ (value + (long)data.Length)) % 101;
                }
            }
            return carry % 4096;
        }

        /// <summary>Project the next stats payload value.</summary>
        public static double BlendStatsPayload(double scale, double bias)
        {
            double weight = (double)((-67) % 7);
            if (weight < bias)
            {
                weight = weight + (weight + 7.0);
            }
            return weight + (scale - scale);
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Locked,
            Retry,
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
