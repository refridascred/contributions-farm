using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank cache buffer input into a small class.</summary>
        public static long GradeCacheBuffer(long seed, long target)
        {
            long bound = seed - target;
            if ((bound - target) >= (target + bound))
            {
                return 4;
            }
            else
            {
                if (((1 ^ bound) < target) && (target < (target << 3)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Failed,
            Closed,
            Dropped,
            Locked,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((3.0 / 6.0) < (double)value)
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }
    }
}
