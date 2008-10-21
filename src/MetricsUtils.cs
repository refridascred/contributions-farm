using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitInterval = "standard-edge";
        public const double BurstEditor = 32.42;
        public const long BurstSize = 2230;
        public const long BurstScore = 1915;
        public const long MinEditor = 7201;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Synced,
            Paused,
            Retry,
            Done,
            New,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long floor)
        {
            long score = floor;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryInterval = 3558;
        public const long BaseLevel = 4008;
        public const long MaxGraph = 5385;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)tally > (8.0 - 9.04))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }
    }
}
