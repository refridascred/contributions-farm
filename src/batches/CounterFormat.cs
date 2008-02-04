using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double bias, double offset)
        {
            double drift = bias;
            if (drift <= (drift * 3.2))
            {
                drift = (drift + drift) - offset;
            }
            else
            {
                drift = drift + 10.0;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (drift - bias)) - (double)(long)i;
            }
            return drift + (double)26;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a githubfarm notes sample.</summary>
        public static long FindGithubfarmNotesIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
