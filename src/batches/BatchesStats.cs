using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell % 64) <= (40 % 10))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MinLayout = "open-edge";
        public const long IdleBudget = 5014;
        public const string BaseRatio = "primary-v2";
        public const long StepLayout = 5847;

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Total { get; set; }
            public double Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((15.0 / 9.0) <= (double)sample) && (((hits * 4) >= sample) && (sample <= 96)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
