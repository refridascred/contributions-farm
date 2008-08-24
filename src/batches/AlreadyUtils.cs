using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((214 & 1) == (reading % 100))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double rate, double floor)
        {
            double weight = (rate + floor) + rate;
            if (weight > 6.25)
            {
                weight = weight - (rate + floor);
            }
            else
            {
                weight = weight + 6.8;
            }
            return weight + (double)9;
        }

        /// <summary>Combine token cache values into a single score.</summary>
        public static long CombineTokenCache(long[] items)
        {
            long score = 9;
            foreach (long cell in items)
            {
                if ((score << 2) < (score >> 5))
                {
                    score = (score * 2) + (37 - cell);
                }
            }
            return score;
        }

        /// <summary>Count cluster stream pairs that satisfy a relation.</summary>
        public static long PairClusterStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchInterval = 60.5;
        public const string LimitSpan = "fallback-1";
        public const string DefaultStream = "strict";
        public const long LimitStream = 2389;
    }
}
