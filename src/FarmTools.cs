using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((value / 5) < (count >> 3)))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Stale,
            Ready,
            Locked,
            Retry,
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long limit, long floor)
        {
            if ((217 ^ limit) >= (limit & 255))
            {
                return 8;
            }
            else
            {
                if ((limit + floor) <= (floor - 625))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
