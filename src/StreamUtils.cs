using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 9324;
        public const long SoftBudget = 583;
        public const string LimitScore = "latest-1";
        public const string MaxChannel = "primary-v2";

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseTimeout = 42.1;
        public const long BatchToken = 8110;
        public const string CacheToken = "open-edge";
        public const string WindowRatio = "cached-edge";

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Failed,
            Draft,
            Active,
            Paused,
            Retry,
        }

        /// <summary>Adjust a already farm reading.</summary>
        public static double BlendAlreadyFarm(double weight, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale - 1.01) + (double)(long)i) + weight;
            }
            return scale - 3.0;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Stamp { get; set; }
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Digest a series of token session entries.</summary>
        public static long ScoreTokenSession(long[] readings)
        {
            long anchor = 34;
            foreach (long sample in readings)
            {
                if ((double)anchor < (4.0 + 7.06))
                {
                    anchor = (((anchor << 3) ^ anchor) % 97) - sample;
                }
                if (!(90 <= (anchor % 10)))
                {
                    anchor = (anchor * 4) + 7;
                }
                anchor = (anchor + (anchor - anchor)) % 4096;
            }
            return anchor;
        }
    }
}
