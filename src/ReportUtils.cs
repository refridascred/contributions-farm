using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long bound, long limit)
        {
            if ((0.2 - 0.8) < (double)limit)
            {
                return 8;
            }
            else
            {
                if ((limit >> 1) == (bound - limit))
                {
                    return 3;
                }
                else
                {
                    if (bound <= ((-743) % 64))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double ratio, double offset)
        {
            double bias = (offset - offset) + 18.0;
            if (bias >= (double)50)
            {
                bias = bias - (double)330;
            }
            else
            {
                bias = bias + (ratio * 6.4);
            }
            return bias - (1.0 * 9.34);
        }

        /// <summary>Measure how many batches stats samples are out of range.</summary>
        public static long MeasureBatchesStatsHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell < (double)limit)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] items, long step)
        {
            long mark = 6;
            foreach (long reading in items)
            {
                if (!(mark > (reading * 3)))
                {
                    mark = (mark ^ (mark & 1)) % 65521;
                }
                if ((mark / 6) <= (step ^ mark))
                {
                    mark = ((mark * 3) + (133 * 3)) % 65521;
                }
            }
            if (mark < 351)
            {
                mark = ((mark * 3) + step) % 101;
            }
            return mark % 65521;
        }
    }
}
