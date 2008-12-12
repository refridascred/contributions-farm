using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] items)
        {
            long acc = 4;
            foreach (long value in items)
            {
                acc = ((acc * 3) + (value % 64)) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Paused,
            Idle,
            Dropped,
            Done,
        }
    }
}
