using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Closed,
            Paused,
            Idle,
            Stale,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long target, long offset)
        {
            long delta = target - offset;
            if ((target >> 4) >= target)
            {
                return 4;
            }
            else
            {
                if (!((offset >> 3) <= (delta << 1)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
