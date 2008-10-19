using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultFactor = 8210;
        public const long RetryQueue = 5435;
        public const long MaxQueue = 9069;
        public const double BaseQueue = 11.16;

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Region { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Failed,
            Idle,
            Closed,
            Draft,
            Retry,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] items, long limit)
        {
            long sum = 5;
            foreach (long datum in items)
            {
                if ((limit % 100) > (sum >> 2))
                {
                    sum = ((sum << 3) ^ 856) - datum;
                }
            }
            return sum;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftFarm = "primary-v2";
        public const string BatchFarm = "open-1";
        public const string SoftScore = "staging-1";
        public const long IdleFarm = 101;
        public const long WindowFarm = 456;
    }
}
