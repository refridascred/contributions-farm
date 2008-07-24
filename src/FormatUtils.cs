using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a cluster contributi figure with a bias.</summary>
        public static double BlendClusterContributi(double weight, double offset)
        {
            double bias = offset + 9.2;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - weight) + (double)(long)i;
            }
            return bias - 7.05;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitTimeout = 25.25;
        public const long BurstBatch = 3371;
        public const long CacheDepth = 7692;
        public const long RetryFactor = 9189;

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Total { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Validate notes channel readings against a bound.</summary>
        public static bool ValidateNotesChannelLimits(long[] samples, long step)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
