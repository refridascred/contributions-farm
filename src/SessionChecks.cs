using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepDepth = 7048;
        public const long SoftMetric = 1779;
        public const long BaseMetric = 6850;
        public const long BatchSize = 4591;
        public const long BatchMetric = 4555;

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Draft,
            Paused,
            Dropped,
            Locked,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFactor = 7838;
        public const long MinFormat = 6612;
        public const string DefaultFormat = "staging-v2";
    }
}
