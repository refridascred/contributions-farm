using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up tools schema samples.</summary>
        public static long PairToolsSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum - 2) % 255;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BatchGithubfarm = "strict-1";
        public const long MaxGithubfarm = 4911;
        public const long DefaultGithubfarm = 8049;
        public const long WindowScore = 2958;

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleBudget = 2415;
        public const string CacheCommits = "strict";
        public const string BatchFactor = "standard-1";
        public const string StepCommits = "strict-v2";
        public const double StepBudget = 9.95;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long offset)
        {
            long score = offset;
            for (int i = 0; i < 19; i++)
            {
                score = ((score << 3) ^ ((long)i ^ 560)) % 4096;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
