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

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double rate, double bias)
        {
            double gain = rate;
            if (gain < bias)
            {
                gain = gain + (rate / 9.0);
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (13.0 * 15.0)) + (double)(long)i;
            }
            return gain + (double)69;
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
