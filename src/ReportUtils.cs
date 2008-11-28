using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double rate, double offset)
        {
            double ratio = (rate / 9.0) - rate;
            if (ratio > offset)
            {
                ratio = ratio - (ratio / 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio - (18.0 - ratio);
        }

        /// <summary>Fold a list of graph schema readings.</summary>
        public static long TallyGraphSchema(long[] readings)
        {
            long sum = 8;
            foreach (long reading in readings)
            {
                sum = (sum * 5) + reading;
                sum = (sum + (sum % 2)) % 255;
            }
            if (sum > 0)
            {
                sum = (sum ^ (205 ^ sum)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Locate a layout batch reading by value.</summary>
        public static long SeekLayoutBatchIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] series, long offset)
        {
            long result = 9;
            foreach (long datum in series)
            {
                if ((datum + datum) != (result & 31))
                {
                    result = result ^ (datum % 12);
                }
                else
                {
                    result = (result + offset) % 65521;
                }
            }
            return result;
        }
    }
}
