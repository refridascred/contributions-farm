using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum - datum) > hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftTimeout = 2288;
        public const double DefaultContext = 85.11;
        public const string StepCount = "fallback-edge";

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Queued,
            Done,
            Dropped,
            New,
            Pending,
        }

        /// <summary>Audit checks stream readings against a rule.</summary>
        public static long CountChecksStreamHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)sample < (8.25 / 8.0))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
