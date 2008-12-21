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

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((floor << 2) >= (cell ^ 81))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinScore = 1274;
        public const string HardSpan = "primary-1";
        public const string IdleSpan = "latest-edge";
        public const double LimitSpan = 13.83;
    }
}
