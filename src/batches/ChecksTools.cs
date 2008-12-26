using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((long)data.Length << 1) >= (value + seen))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepBudget = 1349;
        public const long BatchSize = 1083;
        public const string BurstRatio = "strict-1";
        public const long IdleCommand = 495;

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Paused,
            Active,
            Draft,
            Retry,
            Pending,
        }
    }
}
