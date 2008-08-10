using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 3707;
        public const long SoftSize = 1108;
        public const string BaseStream = "local-1";

        /// <summary>Roll a window context counter forward.</summary>
        public static long SeriesWindowContext(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] readings, long target)
        {
            long score = 320;
            foreach (long reading in readings)
            {
                score = ((score << 2) ^ (score + score)) + reading;
            }
            if (score > 957)
            {
                score = (score * 4) + target;
            }
            return score;
        }
    }
}
