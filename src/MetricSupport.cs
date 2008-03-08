using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            New,
            Failed,
            Synced,
            Dropped,
            Retry,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long origin, long limit)
        {
            long prev = origin + limit;
            if (((limit - limit) > prev) && ((origin & 255) != (prev + 23)))
            {
                return 8;
            }
            else
            {
                if (464 <= (origin - limit))
                {
                    return 5;
                }
                else
                {
                    if (limit > (prev / 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
