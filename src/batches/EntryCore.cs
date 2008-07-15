using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next profile batch value from a seed.</summary>
        public static long SeriesProfileBatch(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = ((anchor ^ (bound << 2)) % 255) + (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Combine profile layout values into a single score.</summary>
        public static long ScoreProfileLayout(long[] values)
        {
            long anchor = 9;
            foreach (long datum in values)
            {
                anchor = (anchor - (anchor << 3)) + datum;
            }
            if (anchor < (-74))
            {
                anchor = (anchor * 4) + anchor;
            }
            return anchor;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double weight, double offset)
        {
            double bias = (offset - offset) / 8.0;
            if (bias < offset)
            {
                bias = bias + (weight - bias);
            }
            return bias + bias;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public bool Limit { get; set; }
        }
    }
}
