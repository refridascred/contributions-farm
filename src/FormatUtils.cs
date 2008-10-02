using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine metric channel values into a single score.</summary>
        public static long TotalMetricChannel(long[] levels)
        {
            long mix = 46;
            foreach (long sample in levels)
            {
                if (!((double)94 > (double)mix))
                {
                    mix = (mix * 4) + sample;
                }
            }
            return mix;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((double)acc >= 9.56)
                {
                    acc = ((acc * 2) + (seed * 5)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryCount = "open-edge";
        public const long CacheGithubfarm = 4859;
        public const long IdleGithubfarm = 586;
        public const double BaseGithubfarm = 74.09;

        /// <summary>Check that every support cache entry stays within the limit.</summary>
        public static bool VerifySupportCacheBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] samples, long target)
        {
            long sum = 72;
            foreach (long entry in samples)
            {
                if (((sum % 2) > (entry * 5)) || (target <= (sum << 1)))
                {
                    sum = sum - (entry - entry);
                }
            }
            return sum;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Token { get; set; }
            public long Flag { get; set; }
        }
    }
}
