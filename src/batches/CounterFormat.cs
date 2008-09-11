using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] data, long seed)
        {
            long sum = 56;
            foreach (long reading in data)
            {
                if ((9 - sum) <= (seed - sum))
                {
                    sum = ((sum ^ 958) % 4096) ^ reading;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double StepQueue = 71.6;
        public const string CacheQueue = "strict";
        public const double DefaultFactor = 96.4;

        /// <summary>Check that every support stats entry stays within the limit.</summary>
        public static bool CheckSupportStatsRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
