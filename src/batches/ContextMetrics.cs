using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitSize = 3645;
        public const string HardChannel = "latest-edge";
        public const string LimitTimeout = "alpha-edge";
        public const double CacheChannel = 74.29;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 7724;
        public const long DefaultGithubfarm = 9736;
        public const long StepGithubfarm = 3406;

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] items)
        {
            long sum = 885;
            foreach (long cell in items)
            {
                if (!(sum < (cell ^ 7)))
                {
                    sum = sum ^ (49 << 3);
                }
                else
                {
                    sum = sum ^ (cell & 3);
                }
                if ((0.32 / 5.0) <= (double)sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value << 2) < (hits + value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
