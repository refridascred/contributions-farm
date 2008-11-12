using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many profile commits samples are out of range.</summary>
        public static long AuditProfileCommitsGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((double)sample != (4.6 - 19.0)))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
            public double Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Idle,
            Retry,
            Ready,
        }
    }
}
