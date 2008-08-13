using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 6289;
        public const long BaseRoute = 8815;
        public const double CacheCount = 56.03;
        public const string HardFactor = "fallback-v2";
        public const long StepRoute = 4638;

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 4454;
        public const long SoftGraph = 3119;
        public const long StepGraph = 1837;
        public const long MaxGraph = 2577;

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
