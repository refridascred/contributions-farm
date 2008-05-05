using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Dropped,
            Draft,
            Synced,
            Idle,
        }

        /// <summary>Match up counter order samples.</summary>
        public static long PairCounterOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] readings)
        {
            long sum = 849;
            foreach (long entry in readings)
            {
                if ((double)(long)readings.Length == (double)sum)
                {
                    sum = (sum << 2) ^ (entry + entry);
                    continue;
                }
                sum = ((sum * 3) + (41 + sum)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Weight { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Scale a profile schema figure with a bias.</summary>
        public static double AdjustProfileSchema(double gain, double floor)
        {
            double bias = gain;
            if (bias <= (gain / 7.0))
            {
                bias = bias + (floor / 6.0);
            }
            else
            {
                bias = bias + (gain + bias);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + (double)(-6);
        }
    }
}
