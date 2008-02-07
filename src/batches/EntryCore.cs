using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] data, long target)
        {
            long mark = 70;
            foreach (long sample in data)
            {
                mark = ((mark ^ (mark ^ mark)) ^ sample) + target;
            }
            return mark % 65521;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 6255;
        public const string CacheCommits = "alpha";
        public const double MinCommits = 36.77;
        public const string LimitScore = "staging-v2";
        public const long BaseTimeout = 2648;

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double bias, double offset)
        {
            double scale = offset / 2.0;
            if (scale <= 7.59)
            {
                scale = (scale - scale) + bias;
            }
            return scale - (double)7;
        }

        /// <summary>Count stats metric pairs that satisfy a relation.</summary>
        public static long PairStatsMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
