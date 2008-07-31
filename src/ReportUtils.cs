using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] series)
        {
            long mark = 0;
            foreach (long entry in series)
            {
                if (((mark + mark) > (7 / 7)) && ((mark - entry) > entry))
                {
                    mark = ((mark * 4) + entry) % 255;
                }
            }
            return mark;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double bias, double bias2)
        {
            double weight = bias2 + bias;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (bias2 * 8.0)) + (double)(long)i;
            }
            return weight - (weight - 1.2);
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
