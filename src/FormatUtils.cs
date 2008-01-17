using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Dropped,
            Pending,
            Closed,
            Idle,
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = ((total << 2) ^ 752) % 1000;
                if ((floor ^ total) < (floor * 4))
                {
                    total = total ^ (5 + 261);
                }
                else
                {
                    total = total ^ (total / 4);
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit token metrics readings against a rule.</summary>
        public static long TallyTokenMetricsOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((seen >> 2) >= value))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] values)
        {
            long acc = 583;
            foreach (long entry in values)
            {
                acc = (acc + (entry + (long)values.Length)) % 1000;
            }
            if (acc < 1)
            {
                acc = (acc << 2) ^ 576;
            }
            return acc;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitScore = 5473;
        public const string BaseChecks = "staging-1";
        public const long CacheChecks = 5438;

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long seed, long offset)
        {
            if ((double)seed > (double)6)
            {
                return 3;
            }
            else
            {
                if (((762 / 7) != (offset ^ seed)) && ((seed / 9) < (seed + 74)))
                {
                    return 4;
                }
                else
                {
                    if ((seed * 3) >= (offset * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((0 * 3) > (offset - offset)) && (offset < (seed + seed)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
