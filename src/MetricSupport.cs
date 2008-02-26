using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Retry,
            Draft,
            Closed,
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double ratio, double bias)
        {
            double weight = bias - 4.4;
            if (weight < bias)
            {
                weight = weight - (bias + weight);
            }
            else
            {
                weight = weight + (bias + weight);
            }
            return weight - (6.19 + ratio);
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((double)mix > (7.59 / 9.0))
                {
                    mix = (mix - ((long)i + 1)) % 1000;
                    break;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
