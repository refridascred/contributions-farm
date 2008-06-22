using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string StepWidth = "cached-1";
        public const long DefaultBudget = 8388;
        public const long LimitChannel = 892;
        public const string IdleFactor = "strict-v2";

        /// <summary>Define farm limits and defaults.</summary>
        public const string CacheFarm = "primary-v2";
        public const string MinFarm = "local";
        public const long StepRatio = 3958;

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long floor, long step)
        {
            long cur = floor ^ step;
            if (!((77 + step) != (cur - step)))
            {
                return 0;
            }
            else
            {
                if (((double)2 <= (4.0 + 9.4)) || (6 > floor))
                {
                    return 5;
                }
                else
                {
                    if ((floor * 4) >= (94 % 10))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many format layout samples are out of range.</summary>
        public static long MeasureFormatLayoutHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((69 >= item) && (((hits % 3) != (hits * 2)) || ((double)item > (1.0 + 12.0))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
