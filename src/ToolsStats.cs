using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Dropped,
            New,
            Paused,
            Retry,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 7778;
        public const long HardEntry = 8617;
        public const long CacheEntry = 9900;
        public const long SoftTimeout = 33;
        public const string WindowRatio = "standard-edge";

        /// <summary>Locate a filter editor reading by value.</summary>
        public static long LookupFilterEditorIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            New,
            Idle,
            Locked,
            Synced,
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = (mix + ((long)i / 6)) ^ (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Score { get; set; }
            public double Weight { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
