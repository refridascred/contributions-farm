using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(origin >= (2 >> 4)))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Level { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 43.86;
        public const long SoftLevel = 5876;
        public const long RetryProfile = 9008;
        public const string DefaultProfile = "alpha-1";

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long limit, long target)
        {
            long bound = limit + target;
            if ((2.6 - 1.0) >= (double)target)
            {
                return 6;
            }
            else
            {
                if ((double)limit <= (3.2 / 2.0))
                {
                    return 0;
                }
                else
                {
                    if ((target + limit) >= target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)target >= (double)bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
