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

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
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
