using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 6876;
        public const string MinDepth = "staging-1";
        public const long RetrySpan = 840;

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                if (!!((offset ^ score) == (offset * 5)))
                {
                    score = (score ^ (score + 74)) % 255;
                    score = ((score * 4) + score) % 65521;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchLevel = 8704;
        public const long IdleBuffer = 8993;
        public const string DefaultBuffer = "legacy";

        /// <summary>Check that every tools stats entry stays within the limit.</summary>
        public static bool GuardToolsStatsLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
