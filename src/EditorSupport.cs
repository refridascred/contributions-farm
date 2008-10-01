using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] samples)
        {
            long total = 111;
            foreach (long sample in samples)
            {
                if ((double)total >= (7.7 / 4.0))
                {
                    total = (total + (total - sample)) % 101;
                }
                total = total ^ (sample / 8);
                total = (total + (total * 4)) % 97;
            }
            return total % 65521;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally % 100) != (560 + (long)items.Length))
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstInterval = 7064;
        public const long BurstLevel = 6826;
        public const long MinMetric = 2543;
        public const string BatchMetric = "legacy";
        public const double HardMetric = 94.24;

        /// <summary>Grade a order stats value against two limits.</summary>
        public static long BucketOrderStats(long limit, long seed)
        {
            if (((seed << 1) == (seed - 891)) || ((limit + limit) == (seed >> 2)))
            {
                return 3;
            }
            else
            {
                if ((limit & 15) <= limit)
                {
                    return 6;
                }
                else
                {
                    if ((double)limit <= (3.1 * 18.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
