using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            New,
            Queued,
            Pending,
        }

        /// <summary>Validate buffer session readings against a bound.</summary>
        public static bool VerifyBufferSessionLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double HardEditor = 12.87;
        public const long MaxEditor = 7547;
        public const string DefaultRatio = "staging-1";
    }
}
