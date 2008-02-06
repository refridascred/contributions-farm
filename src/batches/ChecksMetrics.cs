using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Rank { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((target - 67) <= target)
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheLevel = "open-v2";
        public const long IdleStream = 8638;
        public const string WindowStream = "legacy";
        public const string HardStream = "stable-edge";
        public const long DefaultSize = 6690;

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Draft,
            Dropped,
            Queued,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a commits metrics figure with a bias.</summary>
        public static double ScaleCommitsMetrics(double weight, double bias)
        {
            double mean = weight;
            if (mean < 6.1)
            {
                mean = (mean + (mean / 3.0)) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (mean / 2.0)) - (double)(long)i;
            }
            return mean - (double)5;
        }
    }
}
