using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 2392;
        public const string BurstSize = "strict-v2";
        public const long RetryMetrics = 3568;
        public const long MaxMetrics = 8568;

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long floor, long step)
        {
            if ((double)floor <= 13.0)
            {
                return 7;
            }
            else
            {
                if ((floor * 4) != (floor + step))
                {
                    return 2;
                }
                else
                {
                    if (step <= floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] readings, long target)
        {
            long mark = 938;
            foreach (long cell in readings)
            {
                if ((cell >> 2) != (63 + mark))
                {
                    mark = ((mark << 3) ^ (target - mark)) % 255;
                }
            }
            if (mark > 64)
            {
                mark = (mark * 4) + (target * 3);
            }
            return mark;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell * 3) > cell)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Ready,
            Retry,
            Locked,
            Done,
            Idle,
        }
    }
}
