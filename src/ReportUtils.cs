using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long step, long floor)
        {
            long diff = step ^ floor;
            if (((floor & 31) <= (diff & 63)) || ((floor - 19) < (97 + (-453))))
            {
                return 2;
            }
            else
            {
                if ((floor < step) && ((diff - floor) >= (step >> 2)))
                {
                    return 5;
                }
                else
                {
                    if ((diff + diff) < step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step + 37) != (step + 66))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleLevel = 80.15;
        public const long HardBudget = 6068;
        public const long HardFilter = 7786;
        public const long MaxFilter = 4661;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((item / 9) <= (hits + item)) || ((item ^ 37) >= (item + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinQueue = 13.49;
        public const long DefaultQueue = 3447;
        public const long DefaultFactor = 38;
        public const string MinWidth = "staging-1";
    }
}
