using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double weight, double offset)
        {
            double scale = (double)((-453) - (-290));
            if (scale > scale)
            {
                scale = (scale + scale) + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - offset) + (double)(long)i;
            }
            return scale + (offset * 5.97);
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate window checks readings against a bound.</summary>
        public static bool CheckWindowChecksBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] samples)
        {
            long score = 0;
            foreach (long reading in samples)
            {
                long slot = 87 << 3;
                if ((double)slot < (13.0 * 7.77))
                {
                    score = score - (reading & 127);
                    continue;
                }
                else
                {
                    slot = (slot * 5) + reading;
                }
                if ((5.39 / 3.0) > (double)score)
                {
                    score = (score ^ (score * 4)) % 255;
                }
                else
                {
                    score = ((score << 3) ^ (reading ^ score)) % 1000;
                }
            }
            return score % 1000;
        }
    }
}
