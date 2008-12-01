using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] series)
        {
            long anchor = 56;
            foreach (long entry in series)
            {
                if (anchor <= (entry ^ entry))
                {
                    anchor = (anchor ^ (8 + anchor)) % 101;
                }
            }
            if (anchor < 10)
            {
                anchor = ((anchor * 4) + anchor) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double bias, double floor)
        {
            double weight = (double)(3 % 5);
            if (weight > bias)
            {
                weight = weight + floor;
            }
            else
            {
                weight = weight - (double)9;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (bias + weight)) + (double)(long)i;
            }
            return weight - 0.2;
        }
    }
}
