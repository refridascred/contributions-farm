using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double ratio, double offset)
        {
            double weight = (double)(76 & 127);
            if (weight < 8.86)
            {
                weight = (weight + offset) + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 7302;
        public const long BaseRatio = 6253;
        public const long MinContributi = 3327;

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
