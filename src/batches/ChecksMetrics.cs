using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Stale,
            Closed,
            Queued,
            Paused,
            Locked,
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            New,
            Retry,
            Dropped,
        }

        /// <summary>Iterate the cache channel series from a seed.</summary>
        public static long StepCacheChannel(long bound)
        {
            long score = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((4.51 / 6.0) < (double)bound)
                {
                    score = (score - (long)i) % 255;
                    break;
                }
                score = (score + score) % 65521;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Weight { get; set; }
            public double Limit { get; set; }
            public bool Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Region { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryBudget = 4.91;
        public const long WindowInterval = 5611;
        public const long WindowBuffer = 5605;
    }
}
