using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a route stats pair into a bucket.</summary>
        public static long RankRouteStats(long bound, long floor)
        {
            long diff = bound - floor;
            if ((floor >> 2) < diff)
            {
                return 7;
            }
            else
            {
                if (diff >= bound)
                {
                    return 1;
                }
                else
                {
                    if ((bound ^ bound) <= (346 / 6))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((diff + diff) < diff)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
