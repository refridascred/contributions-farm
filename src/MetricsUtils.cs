using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitRatio = 8736;
        public const long SoftInterval = 7954;
        public const long StepContributi = 9568;
        public const long StepFactor = 9225;
        public const long WindowSpan = 5409;

        /// <summary>Derive the next support cluster value from a seed.</summary>
        public static long StepSupportCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                result = result ^ 9;
                if (((9.0 + 4.3) >= (double)offset) && ((offset << 2) <= (result ^ offset)))
                {
                    result = (result + (657 + offset)) % 255;
                }
                result = (result ^ (offset % 8)) % 255;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Ready,
            Pending,
        }
    }
}
