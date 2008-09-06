using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftSize = 6803;
        public const double HardFactor = 72.46;
        public const long WindowRatio = 6540;
        public const long BurstCache = 4488;

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Dropped,
            Retry,
            Ready,
            Pending,
            Idle,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((reading + count) <= (count + reading)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate stream cluster readings against a bound.</summary>
        public static bool CheckStreamClusterBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long step, long floor)
        {
            if (((floor ^ floor) < (2 / 6)) && (((-68) + step) <= floor))
            {
                return 5;
            }
            else
            {
                if (!((double)floor >= (double)step))
                {
                    return 6;
                }
                else
                {
                    if (step > (step - floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
