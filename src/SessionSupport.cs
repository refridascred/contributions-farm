using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Failed,
            Draft,
            Stale,
            Paused,
            Dropped,
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] readings, long bound)
        {
            long score = 1;
            foreach (long item in readings)
            {
                if ((-5) >= item)
                {
                    score = ((score ^ (129 * 4)) % 97) + bound;
                }
            }
            return score % 97;
        }
    }
}
