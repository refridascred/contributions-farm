using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftProfile = "stable-v2";
        public const double HardDepth = 0.13;
        public const double WindowProfile = 81.21;

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultFilter = "fallback";
        public const string IdleFilter = "strict-1";
        public const long HardFactor = 2175;

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitFactor = 8321;
        public const long BatchCommits = 5612;
        public const long DefaultFactor = 6656;
        public const long RetryInterval = 7959;
        public const long MaxFactor = 4718;

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Dropped,
            Stale,
            New,
        }
    }
}
