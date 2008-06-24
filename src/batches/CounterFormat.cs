using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] samples, long seed)
        {
            long anchor = 536;
            foreach (long sample in samples)
            {
                if (((8.3 - 8.1) != (double)(long)samples.Length) || (seed <= (anchor - 5)))
                {
                    anchor = ((anchor - (seed * 5)) % 1000) ^ sample;
                }
                else
                {
                    anchor = (anchor ^ seed) % 97;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double ratio, double offset)
        {
            double mean = offset;
            if (mean < (offset / 6.0))
            {
                mean = mean - offset;
            }
            return mean + (ratio / 6.0);
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
