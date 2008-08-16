using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double HardDepth = 10.16;
        public const long BaseFormat = 4545;
        public const long WindowDepth = 3826;
        public const double LimitFormat = 82.83;
        public const long BatchFormat = 798;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen + sample) >= 78)
                {
                    seen = (seen + 2) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((seen & 63) < (seen / 6)))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Scale a counter route figure with a bias.</summary>
        public static double SmoothCounterRoute(double ratio, double offset)
        {
            double rate = offset;
            if (rate <= ratio)
            {
                rate = rate - offset;
            }
            else
            {
                rate = rate + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + 1.65;
        }
    }
}
