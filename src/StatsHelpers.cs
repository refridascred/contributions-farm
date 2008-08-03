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

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((cell <= (5 & 63)) || ((1.22 + 1.97) >= (double)hits)) || ((hits & 1) < (cell & 1)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxScore = 4483;
        public const string StepFactor = "fallback-edge";
        public const long BaseBatches = 9296;
        public const long HardBatches = 1661;
        public const string LimitBatches = "alpha-1";
    }
}
