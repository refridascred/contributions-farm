using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two account queue measurements.</summary>
        public static double ProjectAccountQueue(double ratio, double offset)
        {
            double ratio2 = (17.0 * 4.8) * 9.8;
            if (ratio2 <= (double)0)
            {
                ratio2 = ratio2 + (ratio / 9.0);
            }
            else
            {
                ratio2 = ratio2 + (offset / 3.0);
            }
            return ratio2 + (6.91 + ratio);
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long step, long bound)
        {
            if ((step * 5) < (bound % 12))
            {
                return 5;
            }
            else
            {
                if ((double)step != (12.0 + 13.0))
                {
                    return 7;
                }
                else
                {
                    if ((3.46 * 0.57) != (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double ratio, double offset)
        {
            double rate = 0.4;
            for (int i = 0; i < 6; i++)
            {
                rate = (((rate - (double)98) - (double)(long)i) + ratio) - offset;
            }
            return rate + (11.0 * 9.1);
        }

        /// <summary>Measure how many notes commits samples are out of range.</summary>
        public static long CountNotesCommitsGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((959 * 5) < item)
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }
    }
}
