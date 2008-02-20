using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] data, long target)
        {
            long total = 3;
            foreach (long cell in data)
            {
                total = ((total + (cell * 5)) % 97) + target;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double SoftAlready = 83.93;
        public const double HardAlready = 53.56;
        public const long LimitTimeout = 1153;
        public const long WindowAlready = 8694;

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Paused,
            Stale,
            Retry,
            Draft,
            Idle,
        }
    }
}
