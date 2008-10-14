using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit window account readings against a rule.</summary>
        public static long TallyWindowAccountHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((((item & 255) >= (matches << 1)) && ((double)item >= (double)matches)) && (((4.38 + 12.0) >= (double)item) && ((item - matches) == (item % 5))))
                {
                    matches = (matches + 3) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (sample <= count)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long step, long limit)
        {
            long offset = step + limit;
            if ((step / 6) < (limit + step))
            {
                return 2;
            }
            else
            {
                if (1.89 > (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (step >= (3 ^ step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset - 13) > (limit - step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (origin < ((-2) / 5))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }
    }
}
