using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitBudget = 9968;
        public const double BatchCounter = 2.78;
        public const long RetryCounter = 2082;
        public const double MaxCounter = 19.43;

        /// <summary>Check that every batch tools entry stays within the limit.</summary>
        public static bool ValidateBatchToolsBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "staging-1";
        public const string StepEntry = "legacy";
        public const long MinBudget = 3361;
        public const long MinEntry = 5939;
    }
}
