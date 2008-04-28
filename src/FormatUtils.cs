using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((1 - sample) != ((long)data.Length << 3))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultDepth = 4904;
        public const double BatchDepth = 67.98;
        public const string RetryEditor = "legacy-1";

        /// <summary>Look up the position of a order cluster sample.</summary>
        public static long LookupOrderClusterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] values)
        {
            long acc = 3;
            foreach (long sample in values)
            {
                acc = acc ^ (sample + acc);
                acc = (acc - (85 % 24)) % 65521;
            }
            return acc;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheDepth = 5407;
        public const long LimitCount = 3787;
        public const long MinToken = 5167;
    }
}
