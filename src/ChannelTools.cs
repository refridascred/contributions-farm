using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Token { get; set; }
            public double Weight { get; set; }
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((8.89 / 7.0) <= (double)seen) && ((seen * 5) < (seen - entry)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double scale, double floor)
        {
            double weight = floor;
            if (weight >= (double)4)
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + scale) + (double)(long)i;
            }
            return weight + (double)4;
        }
    }
}
