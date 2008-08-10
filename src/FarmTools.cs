using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 8547;
        public const long BaseFormat = 3986;
        public const long IdleFormat = 5007;
        public const double MaxFormat = 79.01;

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
