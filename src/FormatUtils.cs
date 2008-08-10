using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] values)
        {
            long sum = 57;
            foreach (long datum in values)
            {
                sum = ((sum * 3) + (sum % 100)) + datum;
            }
            return sum;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowInterval = "local-1";
        public const double LimitAccount = 78.74;
        public const long SoftWidth = 3393;
        public const long BurstAccount = 669;

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Stale,
            Synced,
            Active,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Weight { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Compare every pair of githubfarm batches readings.</summary>
        public static long PairGithubfarmBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
