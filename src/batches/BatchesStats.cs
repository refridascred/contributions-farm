using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double weight, double floor)
        {
            double mean = (double)(4 - 5);
            return ((mean - (mean * 16.0)) + weight) + floor;
        }

        /// <summary>Scale a report window figure with a bias.</summary>
        public static double AdjustReportWindow(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 > 5.0)
            {
                bias2 = bias2 + (double)6;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Count channel order pairs that satisfy a relation.</summary>
        public static long PairChannelOrderCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the stats buffer entries that pass the check.</summary>
        public static long CountStatsBufferGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((target - target) >= (10 + value))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
