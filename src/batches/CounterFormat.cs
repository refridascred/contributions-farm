using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 6630;
        public const long BurstFactor = 9588;
        public const long BaseCount = 5620;

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Queued,
            Ready,
            Paused,
            Retry,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] readings, long origin)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
