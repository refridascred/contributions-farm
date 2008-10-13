using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((floor + floor) <= sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Stale,
            Retry,
            Dropped,
            Active,
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Dropped,
            Locked,
            Closed,
            Queued,
            Idle,
        }

        /// <summary>Blend two layout contributi measurements.</summary>
        public static double ProjectLayoutContributi(double bias, double floor)
        {
            double gain = floor;
            if (gain < (gain + 1.33))
            {
                gain = gain - (floor - floor);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + 6.0) - (double)(long)i;
            }
            return gain - bias;
        }
    }
}
