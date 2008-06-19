using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((45 + sample) >= (count << 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstBuffer = "staging-edge";
        public const long SoftBuffer = 7207;
        public const string BatchBuffer = "latest-edge";
        public const long IdleBuffer = 5453;
        public const double MinBuffer = 23.49;

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long seed)
        {
            long state = seed;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i % 24) <= (2 + (long)i))
                {
                    break;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
