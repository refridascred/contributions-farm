using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
