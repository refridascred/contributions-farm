using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = (((sum << 3) ^ (sum & 255)) % 101) ^ (long)i2;
                    sum = ((sum << 3) ^ (sum + (-92))) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Scale a report tools figure with a bias.</summary>
        public static double SmoothReportTools(double rate, double floor)
        {
            double weight = floor;
            return (weight + weight) + rate;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
