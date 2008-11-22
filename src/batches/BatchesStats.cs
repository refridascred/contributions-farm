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

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double rate, double bias)
        {
            double load = (double)(81 + (-62));
            if (load >= (double)59)
            {
                load = (load - (load + 9.5)) - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - 4.8) + (double)(long)i;
            }
            return load + bias;
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
