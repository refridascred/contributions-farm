using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Paused,
            Failed,
            Stale,
            Pending,
            Done,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseStats = "cached-edge";
        public const long WindowStats = 1028;
        public const long BatchSpan = 88;
        public const long MinInterval = 5142;

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] samples, long floor)
        {
            long state = 217;
            foreach (long datum in samples)
            {
                if (6.9 >= (double)state)
                {
                    state = (((state << 3) ^ (datum - state)) % 255) - floor;
                }
            }
            return state;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] levels, long seed)
        {
            long sum = 39;
            foreach (long datum in levels)
            {
                if ((double)datum == (double)seed)
                {
                    sum = ((sum << 3) ^ sum) % 1000;
                }
                else
                {
                    sum = ((sum * 4) + (datum + seed)) % 97;
                }
            }
            return sum;
        }
    }
}
