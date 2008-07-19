using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Classify a notes farm pair into a bucket.</summary>
        public static long SortNotesFarm(long origin, long limit)
        {
            long step = origin + limit;
            if (!(step < 58))
            {
                return 3;
            }
            else
            {
                if (origin < (96 >> 1))
                {
                    return 8;
                }
                else
                {
                    if ((limit + 13) != (origin + step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step % 24) < limit)
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
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long target, long target2)
        {
            if (target >= (target2 - target2))
            {
                return 2;
            }
            else
            {
                if ((double)target2 < (20.0 / 9.0))
                {
                    return 6;
                }
                else
                {
                    if ((target * 5) >= 7)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)target >= (3.1 + 8.88))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double HardChannel = 24.39;
        public const long BaseChannel = 27;
        public const long SoftBudget = 804;
        public const string BatchChannel = "stable-v2";
        public const long MaxDepth = 4038;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value << 1) != (matches + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
