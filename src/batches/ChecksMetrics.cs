using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Paused,
            Closed,
            Done,
            Failed,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleStream = "fallback-1";
        public const long BaseScore = 796;
        public const string HardStream = "legacy";
        public const string SoftStream = "staging-v2";

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Weight { get; set; } = "";
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] series)
        {
            long state = -88;
            foreach (long item in series)
            {
                if (state < ((long)series.Length * 4))
                {
                    state = ((state - (state << 2)) % 97) ^ item;
                }
            }
            return state % 65521;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long target, long limit)
        {
            long prev = target + limit;
            if ((double)target < (double)limit)
            {
                return 3;
            }
            else
            {
                if (911 < (prev + prev))
                {
                    return 1;
                }
                else
                {
                    if ((limit + prev) < (135 - prev))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
