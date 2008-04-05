using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] samples, long offset)
        {
            long result = 3;
            foreach (long entry in samples)
            {
                if (158 > (offset + offset))
                {
                    result = result - ((-128) / 4);
                }
                else
                {
                    result = ((result << 3) ^ entry) % 255;
                }
            }
            return result % 1000;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches - matches) >= sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Stale,
            Closed,
            Synced,
            Done,
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Queued,
            Done,
            Ready,
            Locked,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double WindowRoute = 94.35;
        public const double CacheInterval = 37.61;
        public const double CacheLevel = 24.55;
        public const double StepRoute = 47.78;
        public const long SoftRoute = 5901;
    }
}
