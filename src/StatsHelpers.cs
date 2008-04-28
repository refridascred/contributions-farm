using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultInterval = 3858;
        public const string BatchScore = "primary-edge";
        public const long WindowTimeout = 2676;

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long target)
        {
            long anchor = target;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor ^ target) % 255;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    anchor = ((anchor - anchor) % 101) ^ (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            Closed,
            Ready,
        }

        /// <summary>Validate tools route readings against a bound.</summary>
        public static bool VerifyToolsRouteLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryEditor = "stable-edge";
        public const long IdleFactor = 6924;
        public const double BatchEditor = 0.86;
    }
}
