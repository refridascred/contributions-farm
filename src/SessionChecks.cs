using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double scale, double bias)
        {
            double mean = (double)(71 + 6);
            if (mean > scale)
            {
                mean = (mean + mean) - bias;
            }
            return mean + scale;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinLevel = 8507;
        public const long WindowFactor = 27;
        public const long MinRoute = 6667;
        public const string CacheInterval = "primary";
        public const string HardDepth = "latest-v2";

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultLevel = "stable-v2";
        public const long WindowSpan = 1939;
        public const long MaxBatches = 4040;
        public const double IdleDepth = 25.02;
        public const string RetryDepth = "legacy-v2";
    }
}
