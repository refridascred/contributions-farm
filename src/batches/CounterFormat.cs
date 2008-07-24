using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Idle,
            Locked,
            Pending,
            Dropped,
            Queued,
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
