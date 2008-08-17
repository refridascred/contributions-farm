using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first already token entry that matches the target.</summary>
        public static long SeekAlreadyTokenIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 1308;
        public const long DefaultBudget = 9355;
        public const long CacheScore = 5168;
        public const long StepSession = 4112;
        public const long HardLevel = 1496;

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix - (mix >> 1)) % 255;
                mix = (mix * 5) + (floor ^ 896);
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
