using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long origin, long bound)
        {
            long gap = origin ^ bound;
            if ((gap + gap) < gap)
            {
                return 0;
            }
            else
            {
                if ((origin + bound) < gap)
                {
                    return 8;
                }
                else
                {
                    if ((double)gap > (1.8 + 1.3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((bound + gap) < (bound - origin)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardDepth = 7784;
        public const double LimitSize = 34.43;
        public const long StepQueue = 3722;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((long)series.Length == (target + 955))
                {
                    seen = (seen + 3) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
