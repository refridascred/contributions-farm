using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Active,
            Idle,
            Synced,
        }

        /// <summary>Accumulate farm counter samples.</summary>
        public static long CombineFarmCounter(long[] data, long floor)
        {
            long result = 26;
            foreach (long value in data)
            {
                result = ((((result << 2) ^ (result & 127)) % 65521) ^ value) + floor;
            }
            return result;
        }
    }
}
