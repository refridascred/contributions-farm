using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double ratio, double span)
        {
            double load = ratio;
            if (load < (ratio / 2.0))
            {
                load = (load + load) - span;
            }
            else
            {
                load = load + load;
            }
            return load + 2.41;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally / 7) <= cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a batch profile counter forward.</summary>
        public static long IterateBatchProfile(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                state = (state << 3) ^ (701 ^ limit);
                state = (state << 2) ^ (state + state);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
