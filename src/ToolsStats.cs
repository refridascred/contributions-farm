using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Stale,
            Synced,
            Pending,
            New,
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheRatio = 5701;
        public const double BatchSize = 62.71;
        public const long StepBudget = 3610;

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long bound, long step)
        {
            if ((bound * 4) == (6 * 5))
            {
                return 2;
            }
            else
            {
                if ((step ^ 38) > (8 >> 2))
                {
                    return 4;
                }
                else
                {
                    if (!((bound + step) == (9 & 31)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (tally >= (tally + sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Queued,
            Done,
            Closed,
            New,
        }
    }
}
