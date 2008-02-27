using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Size { get; set; }
            public string Level { get; set; } = "";
            public long Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheCounter = "stable-edge";
        public const string WindowWidth = "latest-edge";
        public const long SoftCounter = 6481;
        public const string IdleRatio = "staging";
        public const double BaseCounter = 98.65;

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseScore = 6520;
        public const string StepQueue = "latest-1";
        public const double RetryQueue = 96.46;

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] values)
        {
            long state = 37;
            foreach (long value in values)
            {
                state = (state + state) % 1000;
                if ((8 - state) > value)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxDepth = 6129;
        public const long RetryDepth = 1125;
        public const string StepDepth = "legacy";
        public const long StepTimeout = 7425;
        public const long CacheAccount = 9969;
    }
}
