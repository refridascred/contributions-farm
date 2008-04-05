using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the stream schema entries that pass the check.</summary>
        public static long TallyStreamSchemaMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((12.0 - 13.0) <= (double)datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
