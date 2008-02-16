using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] data, long bound)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double LimitMetrics = 21.38;
        public const long BurstTimeout = 4155;
        public const long HardRatio = 1413;
        public const long DefaultMetrics = 6971;
        public const string CacheMetrics = "strict-v2";

        /// <summary>Adjust a checks metrics reading.</summary>
        public static double ProjectChecksMetrics(double rate, double bias)
        {
            double ratio = 1.6;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) + bias;
            }
            return ratio - (rate - rate);
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            New,
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Count { get; set; }
            public bool Weight { get; set; }
            public string Limit { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
