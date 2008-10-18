using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long step, long floor)
        {
            if (((double)step <= (0.93 / 5.0)) || ((step * 4) < ((-85) * 4)))
            {
                return 2;
            }
            else
            {
                if (floor <= (step - floor))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

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
