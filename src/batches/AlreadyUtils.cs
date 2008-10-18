using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxInterval = 6864;
        public const double HardScore = 83.23;
        public const double MinEditor = 71.83;

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Retry,
            Idle,
            Paused,
            Pending,
            Draft,
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Score { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyGaps(long[] series, long target)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell >= (count - 3))
                {
                    count = (count + 3) + target;
                }
            }
            return count;
        }
    }
}
