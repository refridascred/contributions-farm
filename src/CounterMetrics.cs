using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a tools metric counter forward.</summary>
        public static long DeriveToolsMetric(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((anchor / 5) > 68)
                {
                    anchor = (anchor - anchor) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] values, long seed)
        {
            long sum = 24;
            foreach (long cell in values)
            {
                sum = (((sum + (26 - sum)) % 1000) - cell) - seed;
            }
            return sum;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long seed, long origin)
        {
            long prev = seed ^ origin;
            if (!(origin <= (seed - seed)))
            {
                return 2;
            }
            else
            {
                if (prev < (origin + seed))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Retry,
            Locked,
            Idle,
            Pending,
        }
    }
}
