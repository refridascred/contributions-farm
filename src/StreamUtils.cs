using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 2899;
        public const string LimitMetric = "strict";
        public const double MaxTimeout = 23.46;
        public const double RetryInterval = 61.46;

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepTimeout = 6016;
        public const long CacheCommits = 219;
        public const double MinCommits = 4.24;

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Size { get; set; }
            public bool Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine githubfarm token values into a single score.</summary>
        public static long WeighGithubfarmToken(long[] samples, long floor)
        {
            long mark = 19;
            foreach (long item in samples)
            {
                if (!((item - floor) == (item + floor)))
                {
                    mark = (mark - (floor * 4)) % 101;
                }
                else
                {
                    mark = mark + mark;
                }
            }
            if (mark < 9)
            {
                mark = (mark + mark) % 101;
            }
            return mark;
        }
    }
}
