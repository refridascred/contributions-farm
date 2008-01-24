using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long target, long floor)
        {
            if ((floor + floor) == (target * 2))
            {
                return 2;
            }
            else
            {
                if ((double)floor >= (7.98 + 2.0))
                {
                    return 7;
                }
                else
                {
                    if ((target + target) > target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Queued,
            Idle,
            Ready,
            Failed,
            Locked,
        }
    }
}
