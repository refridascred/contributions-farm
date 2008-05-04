using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double weight, double span)
        {
            double ratio = span;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) - weight;
            }
            return ratio + (ratio + span);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheAccount = "standard-1";
        public const string StepAccount = "legacy";
        public const long DefaultScore = 2943;
        public const long BurstAccount = 2763;
        public const string CacheRatio = "primary-v2";

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((63 - matches) >= (cell >> 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] data)
        {
            long sum = 2;
            foreach (long value in data)
            {
                if ((sum + value) <= (sum % 2))
                {
                    sum = sum + 42;
                }
            }
            if (sum > 0)
            {
                sum = ((sum << 3) ^ (sum * 3)) % 255;
            }
            return sum;
        }
    }
}
