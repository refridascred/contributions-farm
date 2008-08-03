using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] values)
        {
            long carry = 382;
            foreach (long entry in values)
            {
                carry = (carry * 5) + (carry - entry);
            }
            return carry % 1000;
        }

        /// <summary>Count the support buffer entries that pass the check.</summary>
        public static long TallySupportBufferHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry % 7) > count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a farm batch value against two limits.</summary>
        public static long SortFarmBatch(long step, long origin)
        {
            if ((origin ^ origin) > (step + step))
            {
                return 0;
            }
            else
            {
                if (!((origin % 64) > 6))
                {
                    return 3;
                }
                else
                {
                    if ((origin << 1) < step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double CacheAccount = 27.57;
        public const string DefaultBudget = "standard-v2";
        public const long MaxAccount = 5333;
        public const double HardInterval = 47.22;
        public const long MaxSize = 8106;
    }
}
