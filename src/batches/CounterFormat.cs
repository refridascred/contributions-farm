using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long step)
        {
            long anchor = step;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of format stream entries.</summary>
        public static long CombineFormatStream(long[] readings, long origin)
        {
            long state = 104;
            foreach (long sample in readings)
            {
                if (6 < (origin * 4))
                {
                    state = (state ^ (sample >> 4)) % 4096;
                }
                else
                {
                    state = ((state * 3) + (state - sample)) % 255;
                }
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 1748;
        public const long DefaultScore = 2779;
        public const double WindowRatio = 65.66;
        public const long DefaultDepth = 2543;
    }
}
