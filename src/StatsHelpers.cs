using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Ready,
            Draft,
            Active,
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] samples, long limit)
        {
            long state = -9;
            foreach (long value in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    state = ((state - value) % 65521) - (long)i;
                    state = (state + (state >> 3)) % 255;
                }
                state = (state << 3) ^ (limit % 3);
            }
            return state;
        }
    }
}
