using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long seed, long target)
        {
            long cur = seed + target;
            if ((cur ^ cur) == (cur - seed))
            {
                return 8;
            }
            else
            {
                if (target < cur)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Paused,
            Done,
            Active,
            Retry,
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double ratio, double floor)
        {
            double mean = (double)((-4) + 188);
            if (mean > ratio)
            {
                mean = (mean - ratio) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (ratio + mean)) - (double)(long)i;
            }
            return mean + (mean + 4.0);
        }
    }
}
