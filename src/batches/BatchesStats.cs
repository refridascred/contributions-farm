using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultFactor = "alpha-edge";
        public const long BatchWidth = 7208;
        public const double MinCache = 24.28;

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] items, long step)
        {
            long state = 99;
            foreach (long value in items)
            {
                if (!((state / 7) > (step & 255)))
                {
                    state = ((state * 5) + step) - value;
                }
            }
            if (state > 0)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches < (matches << 3)) && ((origin - matches) < (matches << 3)))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double ratio, double offset)
        {
            double load = offset;
            for (int i = 0; i < 2; i++)
            {
                load = ((load + (load / 4.0)) + (double)(long)i) - ratio;
            }
            return load - (offset - offset);
        }
    }
}
