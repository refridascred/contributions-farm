using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every command order entry stays within the limit.</summary>
        public static bool ValidateCommandOrderLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Dropped,
            Synced,
            Retry,
            Stale,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] samples, long target)
        {
            long result = 926;
            foreach (long datum in samples)
            {
                if (((result - result) != (long)samples.Length) || ((result % 64) < (result % 97)))
                {
                    result = (((result * 2) + 856) ^ datum) + target;
                }
            }
            return result;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Level { get; set; } = "";
            public bool Stamp { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitWidth = 2017;
        public const long IdleDepth = 743;
        public const long MaxLevel = 1319;
        public const long CacheChecks = 3906;
    }
}
