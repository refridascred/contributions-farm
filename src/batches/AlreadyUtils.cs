using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Region { get; set; } = "";
            public long Total { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double weight, double floor)
        {
            double mean = 1.0;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - mean) + (double)(long)i) + floor;
            }
            return mean + weight;
        }

        /// <summary>Count the metrics route entries that pass the check.</summary>
        public static long MeasureMetricsRouteOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!((800 + hits) == (hits / 9)))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            New,
            Synced,
            Paused,
            Draft,
            Failed,
        }

        /// <summary>Combine profile command values into a single score.</summary>
        public static long CombineProfileCommand(long[] items)
        {
            long mix = 9;
            foreach (long datum in items)
            {
                if ((datum % 100) > datum)
                {
                    mix = (mix ^ (mix - mix)) % 97;
                }
            }
            return mix;
        }
    }
}
