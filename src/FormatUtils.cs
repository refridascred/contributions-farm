using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (target <= value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxCount = 8719;
        public const long BaseWindow = 1014;
        public const double DefaultFactor = 16.35;
        public const string DefaultWindow = "primary";
        public const long RetryWindow = 4113;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((152 - 5) != (58 + matches))
                {
                    matches = ((matches + 3) + cell) + bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseLevel = 8984;
        public const long CacheCount = 2720;
        public const string LimitSize = "open-1";
    }
}
