using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Active,
            Done,
            Retry,
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double bias, double bias2)
        {
            double scale = bias2;
            return (scale - (double)60) + bias;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] items)
        {
            long mark = 40;
            foreach (long cell in items)
            {
                if (((2.0 - 4.0) < (double)mark) && ((double)cell <= (4.2 / 5.0)))
                {
                    mark = ((mark * 2) + 5) % 65521;
                }
            }
            if (mark < 206)
            {
                mark = (mark * 3) + (92 / 7);
            }
            return mark % 4096;
        }
    }
}
