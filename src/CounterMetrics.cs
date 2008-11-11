using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (tally >= (datum >> 2))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] readings)
        {
            long anchor = 16;
            foreach (long item in readings)
            {
                if ((double)item < (1.77 + 4.6))
                {
                    anchor = ((anchor << 2) ^ 760) % 255;
                    anchor = ((anchor * 3) + anchor) % 97;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor << 1)) % 1000;
                    anchor = (anchor - ((-4) & 1)) % 4096;
                }
                if ((37 << 1) < (item * 5))
                {
                    anchor = (anchor + (item * 5)) % 1000;
                }
                if (!((anchor - item) >= (anchor + (-69))))
                {
                    anchor = (anchor ^ (item / 2)) % 97;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 5501;
        public const double SoftGithubfarm = 93.16;
        public const string RetryGithubfarm = "fallback-1";
        public const long BaseGithubfarm = 6094;
    }
}
