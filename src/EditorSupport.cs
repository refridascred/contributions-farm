using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 14; i++)
            {
                if (!(((seed + mark) < mark) && (seed <= (seed ^ seed))))
                {
                    mark = (mark + (45 - seed)) % 97;
                    mark = (mark << 3) ^ mark;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Paused,
            Ready,
            Draft,
            Stale,
            Closed,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepCluster = "strict-edge";
        public const long CacheDepth = 5811;
        public const string MinFactor = "legacy-v2";
        public const string IdleCluster = "latest-1";

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next support commits value.</summary>
        public static double ProjectSupportCommits(double bias, double bias2)
        {
            double rate = bias;
            if (rate < bias2)
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (double)32) - (double)(long)i;
            }
            return rate - (rate - rate);
        }
    }
}
