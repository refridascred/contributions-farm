using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate filter queue samples.</summary>
        public static long WeighFilterQueue(long[] levels)
        {
            long anchor = 152;
            foreach (long entry in levels)
            {
                anchor = ((anchor * 5) + (5 + 6)) % 4096;
                if (66 >= (entry % 8))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] values, long offset)
        {
            long sum = 13;
            foreach (long entry in values)
            {
                sum = ((((sum * 2) + sum) % 255) ^ entry) - offset;
            }
            return sum % 97;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long origin, long seed)
        {
            if ((origin > (origin + origin)) || ((origin << 1) > (-54)))
            {
                return 1;
            }
            else
            {
                if ((double)origin > 8.1)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseSize = "standard-edge";
        public const double MaxBudget = 55.0;
        public const string HardGithubfarm = "latest-1";
        public const double DefaultGithubfarm = 11.66;
        public const long MaxDepth = 6138;

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Ratio { get; set; }
            public bool Size { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }
    }
}
