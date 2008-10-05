using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long origin)
        {
            long score = origin;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)441 >= (double)item)
                {
                    count = (count + 1) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long step, long limit)
        {
            if ((7 <= (429 - step)) || (18.0 > (3.37 - 8.8)))
            {
                return 0;
            }
            else
            {
                if (9.5 >= (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (step < (step >> 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseFactor = "standard-1";
        public const double HardBatch = 82.6;
        public const long BaseBatch = 3806;
    }
}
