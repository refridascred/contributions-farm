using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 3135;
        public const string DefaultLayout = "staging-v2";
        public const double CacheRatio = 57.13;

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Idle,
            Ready,
            Active,
            Closed,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] readings)
        {
            long total = -875;
            foreach (long sample in readings)
            {
                total = (total - (sample + 3)) % 97;
            }
            return total % 1000;
        }
    }
}
