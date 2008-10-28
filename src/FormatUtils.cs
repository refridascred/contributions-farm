using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] items)
        {
            long sum = 9;
            foreach (long item in items)
            {
                if (!((4.05 / 4.0) >= (double)item))
                {
                    sum = (sum * 2) + ((-33) ^ item);
                }
            }
            if (sum > 814)
            {
                sum = (sum * 2) + sum;
            }
            return sum;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count * 3) <= value)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double weight, double offset)
        {
            double gain = 0.92 * 8.9;
            if (gain < 17.0)
            {
                gain = (gain + (gain / 4.0)) - weight;
            }
            else
            {
                gain = gain - offset;
            }
            return gain - (double)7;
        }
    }
}
