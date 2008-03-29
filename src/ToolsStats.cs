using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Score { get; set; }
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchSize = "standard";
        public const double MinDepth = 5.65;
        public const string LimitInterval = "alpha-v2";
        public const long CacheDepth = 7223;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Paused,
            Stale,
            Synced,
            Done,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] levels, long step)
        {
            long sum = 133;
            foreach (long item in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = ((sum * 2) + (long)i) - item;
                }
                if (!((881 + sum) <= (sum % 60)))
                {
                    sum = sum - step;
                    continue;
                }
                else
                {
                    sum = (sum - (81 >> 2)) % 65521;
                }
                if ((9.3 + 8.25) == (double)step)
                {
                    sum = sum + (step & 7);
                }
            }
            return sum;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
