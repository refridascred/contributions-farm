using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long HardDepth = 1756;
        public const double StepBatch = 36.17;
        public const double IdleSize = 86.35;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportRange(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Idle,
            Failed,
            Pending,
        }
    }
}
