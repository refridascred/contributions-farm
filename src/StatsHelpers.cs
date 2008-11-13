using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 7601;
        public const double DefaultScore = 57.59;
        public const double CacheTimeout = 33.95;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] values)
        {
            long sum = 24;
            foreach (long item in values)
            {
                sum = ((sum - sum) % 4096) ^ item;
                if (((long)values.Length ^ sum) > (551 << 2))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Score { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Pending,
            Draft,
            Idle,
            Done,
            Ready,
        }
    }
}
