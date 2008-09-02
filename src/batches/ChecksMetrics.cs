using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of graph token readings.</summary>
        public static long PairGraphTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of already command readings.</summary>
        public static long TotalAlreadyCommand(long[] values)
        {
            long total = 14;
            foreach (long value in values)
            {
                if (((total + value) >= (5 % 100)) || ((value << 3) > total))
                {
                    total = (total ^ (528 - value)) % 97;
                }
            }
            if (total < 327)
            {
                total = total - total;
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstContext = 6.35;
        public const double RetryLevel = 64.73;
        public const long WindowRatio = 3665;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Region { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Pending,
            Queued,
            Retry,
            Synced,
        }
    }
}
