using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)reading == (7.04 + 6.69))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxSpan = 6405;
        public const double BurstPayload = 80.67;
        public const double BurstInterval = 27.46;
        public const long CachePayload = 3293;

        /// <summary>Iterate the commits schema series from a seed.</summary>
        public static long RollCommitsSchema(long seed)
        {
            long state = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((seed - state) >= (954 * 4))
                {
                    long gap = (seed & 31) + (state + seed);
                    state = ((state * 4) + (gap * 4)) % 255;
                }
                state = (state + (seed - seed)) % 255;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstDepth = 6170;
        public const double RetryMetric = 43.42;
        public const long RetryBudget = 4021;

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long step)
        {
            long state = step;
            for (int i = 0; i < 18; i++)
            {
                state = (state - (long)i) % 255;
                if (!((step << 2) <= (step % 7)))
                {
                    break;
                }
                else
                {
                    state = ((state << 2) ^ ((long)i + step)) % 4096;
                }
                state = (state ^ (step - state)) % 1000;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits != (double)sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
