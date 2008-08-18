using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate record cache readings against a bound.</summary>
        public static bool VerifyRecordCacheBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double gain, double floor)
        {
            double bias = floor;
            if (bias <= (floor + floor))
            {
                bias = bias - gain;
            }
            return bias - (double)786;
        }

        /// <summary>Combine stream buffer values into a single score.</summary>
        public static long CombineStreamBuffer(long[] data)
        {
            long mark = 33;
            foreach (long value in data)
            {
                mark = (mark + (mark - (-415))) ^ value;
            }
            return mark;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long offset, long seed)
        {
            long edge = offset + seed;
            if ((17 << 1) == (offset ^ edge))
            {
                return 5;
            }
            else
            {
                if ((offset * 2) >= (66 & 7))
                {
                    return 6;
                }
                else
                {
                    if ((edge ^ offset) <= edge)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double weight, double offset)
        {
            double gain = offset;
            if (gain >= (double)344)
            {
                gain = gain + (weight - gain);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - (gain / 9.0);
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
