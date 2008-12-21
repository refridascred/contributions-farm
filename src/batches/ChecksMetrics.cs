using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 2889;
        public const long SoftInterval = 9440;
        public const double BurstMetrics = 26.65;
        public const double MaxMetrics = 50.62;

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long step, long origin)
        {
            if (!((step / 7) > step))
            {
                return 5;
            }
            else
            {
                if ((double)step <= (18.0 + 12.0))
                {
                    return 3;
                }
                else
                {
                    if ((step << 2) < (origin + origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin + step) > origin)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Stale,
            Retry,
            Closed,
            New,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!(seen > (seen + entry)) && ((seen + target) > (1 - seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string LimitTimeout = "legacy-edge";
        public const string CacheInterval = "alpha-1";
        public const long SoftScore = 3056;
    }
}
