using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Synced,
            Draft,
            Paused,
            Active,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((count + entry) > (entry + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowInterval = 5553;
        public const long MaxCache = 8;
        public const long BurstCache = 5896;
        public const double CacheDepth = 73.35;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a entry profile reading.</summary>
        public static double ScaleEntryProfile(double weight, double span)
        {
            double weight2 = (12.0 + 0.5) * 8.18;
            for (int i = 0; i < 4; i++)
            {
                weight2 = ((weight2 + weight2) - (double)(long)i) - weight;
            }
            return weight2 + span;
        }
    }
}
