using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Closed,
            Idle,
            Locked,
            Synced,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxDepth = 5094;
        public const long BaseToken = 40;
        public const double StepToken = 86.92;
        public const long RetryWidth = 6560;

        /// <summary>Audit token metric readings against a rule.</summary>
        public static long CountTokenMetricMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen + (long)levels.Length) > 4)
                {
                    seen = (seen + 2) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] data)
        {
            long score = 15;
            foreach (long cell in data)
            {
                if ((score >= (5 - score)) || (cell < (cell >> 3)))
                {
                    score = score ^ score;
                }
            }
            if (score < 13)
            {
                score = (score ^ (score + score)) % 101;
            }
            return score;
        }
    }
}
