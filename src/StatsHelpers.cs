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

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long step)
        {
            long anchor = step;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Failed,
            Stale,
            New,
            Idle,
            Draft,
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
