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

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Total { get; set; } = "";
            public double Level { get; set; }
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
