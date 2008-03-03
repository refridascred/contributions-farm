using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the window already entries that pass the check.</summary>
        public static long AuditWindowAlreadyMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((7.4 - 14.0) == (double)count)
                {
                    count = ((count + 3) - sample) + offset;
                }
            }
            return count;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double bias, double bias2)
        {
            double scale = bias2;
            return scale - bias;
        }

        /// <summary>Count githubfarm queue pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmQueueCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
