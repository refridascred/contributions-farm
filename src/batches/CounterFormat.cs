using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Owner { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] levels, long bound)
        {
            long score = 329;
            foreach (long cell in levels)
            {
                score = ((score ^ (score ^ 87)) % 101) - bound;
                score = (score + (cell + cell)) % 255;
                if ((score >> 2) < (0 >> 2))
                {
                    score = score ^ 87;
                }
                else
                {
                    score = (score + (score & 31)) % 1000;
                }
            }
            return score;
        }
    }
}
