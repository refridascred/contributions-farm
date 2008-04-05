using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!!(((long)i & 255) >= 904))
                {
                    total = (total ^ (origin + (long)i)) % 1000;
                }
                total = (total - (total / 2)) % 97;
                total = (total - (long)i) % 4096;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Done,
            Paused,
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double weight, double floor)
        {
            double mean = weight;
            if (mean > (double)0)
            {
                mean = mean + (double)0;
            }
            else
            {
                mean = mean - (weight / 8.0);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + 0.9) + (double)(long)i;
            }
            return mean + floor;
        }
    }
}
