using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double bias, double floor)
        {
            double weight = (2.3 - bias) / 4.0;
            if (weight > (bias * 4.56))
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight + (14.0 - weight);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + (floor / 2.0);
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] samples, long offset)
        {
            long mark = 4;
            foreach (long sample in samples)
            {
                if ((184 + mark) <= mark)
                {
                    mark = ((mark - (offset % 97)) % 101) ^ sample;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of metric report readings.</summary>
        public static long CompareMetricReportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Pending,
            Draft,
            Closed,
            Idle,
        }
    }
}
