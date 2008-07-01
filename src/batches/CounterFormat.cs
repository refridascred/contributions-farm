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

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] values)
        {
            long mix = 19;
            foreach (long sample in values)
            {
                mix = (((mix << 3) ^ (mix * 5)) % 1000) - sample;
            }
            return mix % 1000;
        }
    }
}
