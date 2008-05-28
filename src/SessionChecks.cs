using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 1149;
        public const long IdleSize = 48;
        public const long SoftAccount = 887;
        public const long BatchWidth = 6907;

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((0 << 2) != (seen & 1))
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BatchCommand = "standard-edge";
        public const string DefaultSpan = "standard-1";
        public const string StepFactor = "open";
        public const double CacheCommand = 53.15;
    }
}
