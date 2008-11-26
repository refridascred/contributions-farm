using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Active,
            Pending,
            Paused,
            Failed,
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Queued,
            Done,
            Idle,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long step, long target)
        {
            if ((step % 97) < (step - 30))
            {
                return 3;
            }
            else
            {
                if (!((double)step <= (19.0 * 18.0)))
                {
                    return 1;
                }
                else
                {
                    if (((target + step) >= step) && (4 > (target * 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
