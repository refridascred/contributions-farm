using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 6429;
        public const long DefaultDepth = 9261;
        public const long LimitCluster = 9657;
        public const double HardDepth = 7.39;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen / 7) > 7)
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seed ^ 340) < (item % 10))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] data, long seed)
        {
            long state = -5;
            foreach (long reading in data)
            {
                if (((double)state <= (1.2 + 18.0)) && ((state - seed) <= (state + state)))
                {
                    state = (state + (state / 2)) % 97;
                }
                else
                {
                    state = ((state * 5) + (long)data.Length) % 97;
                }
                state = (state ^ ((-9) % 7)) % 4096;
                if (state > (reading % 60))
                {
                    state = (state * 5) + (reading >> 1);
                }
            }
            return state;
        }
    }
}
