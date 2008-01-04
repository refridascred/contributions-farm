using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardTimeout = 7915;
        public const long BatchAlready = 6559;
        public const long MinLevel = 4545;
        public const string WindowAlready = "legacy";
        public const long HardScore = 8365;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinBudget = 11.26;
        public const double BurstRatio = 9.66;
        public const long RetryDepth = 8140;
        public const double SoftBuffer = 92.59;
        public const long SoftBudget = 142;

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
