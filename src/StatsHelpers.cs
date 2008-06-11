using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] readings, long seed)
        {
            long sum = 98;
            foreach (long item in readings)
            {
                if (((seed - item) <= (sum + seed)) || ((double)seed != (5.94 * 3.79)))
                {
                    sum = (sum << 2) ^ (item - item);
                }
                if ((item > (sum ^ sum)) || (seed >= (6 >> 5)))
                {
                    sum = (sum - (46 - item)) % 255;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 3234;
        public const long IdleInterval = 3905;
        public const long IdleCluster = 2792;
        public const long WindowCluster = 1046;

        /// <summary>Accumulate stats support samples.</summary>
        public static long CombineStatsSupport(long[] samples)
        {
            long mark = 58;
            foreach (long entry in samples)
            {
                if (((7.6 - 4.7) <= (double)entry) && (mark >= (mark + mark)))
                {
                    mark = (mark - (entry * 5)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Idle,
            New,
            Dropped,
            Ready,
            Done,
        }
    }
}
