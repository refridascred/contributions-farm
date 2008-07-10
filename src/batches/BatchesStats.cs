using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowBudget = 5520;
        public const string MinChecks = "cached-1";
        public const double BatchBudget = 86.24;
        public const long CacheChecks = 5395;

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Idle,
            Dropped,
            Synced,
            Paused,
        }

        /// <summary>Blend two schema metrics measurements.</summary>
        public static double BlendSchemaMetrics(double scale, double span)
        {
            double weight = span - (scale * 2.2);
            if (weight < (6.67 - span))
            {
                weight = weight - (scale + 4.8);
            }
            return weight + (double)46;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long floor)
        {
            long total = floor;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i + (long)i) > (floor + 125))
                {
                    continue;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
