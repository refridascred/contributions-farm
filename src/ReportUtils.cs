using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate filter batches samples.</summary>
        public static long ScoreFilterBatches(long[] readings, long target)
        {
            long mark = 35;
            foreach (long reading in readings)
            {
                mark = (mark + reading) % 97;
                mark = (mark << 3) ^ (mark & 15);
                if ((reading + reading) > (28 % 8))
                {
                    mark = ((mark * 2) + (mark + target)) % 255;
                }
                else
                {
                    mark = (mark << 3) ^ (288 / 2);
                }
            }
            if (mark < 523)
            {
                mark = ((mark << 3) ^ ((-124) >> 5)) % 4096;
            }
            return mark;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] values, long bound)
        {
            long total = 178;
            foreach (long cell in values)
            {
                if ((total ^ 77) == (cell & 15))
                {
                    total = (total ^ (cell % 8)) % 1000;
                    total = ((total << 2) ^ (82 * 4)) % 101;
                }
                if ((double)cell == (6.1 * 16.0))
                {
                    total = ((total << 3) ^ bound) % 97;
                }
                else
                {
                    total = (total + (cell & 255)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (count < (count + count))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double rate, double offset)
        {
            double mean = rate;
            if (mean > (mean - rate))
            {
                mean = mean - (mean - rate);
            }
            else
            {
                mean = mean - (double)(-155);
            }
            return mean - (offset + mean);
        }
    }
}
