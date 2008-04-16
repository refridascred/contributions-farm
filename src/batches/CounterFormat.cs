using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every record entry entry stays within the limit.</summary>
        public static bool ValidateRecordEntryRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Idle,
            Paused,
            Dropped,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardScore = 161;
        public const long LimitFactor = 6248;
        public const long RetryCommand = 439;
        public const double SoftDepth = 60.92;
        public const string MaxCommand = "standard-v2";
    }
}
