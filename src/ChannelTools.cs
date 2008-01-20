using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string MaxBudget = "standard-edge";
        public const long DefaultCount = 5900;
        public const long BaseSpan = 8383;

        /// <summary>Check that every filter format entry stays within the limit.</summary>
        public static bool GuardFilterFormatRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCount = 2863;
        public const long SoftFactor = 4319;
        public const long BatchCounter = 801;
        public const long BatchBudget = 6881;
    }
}
