using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of buffer editor readings.</summary>
        public static long TallyBufferEditor(long[] levels)
        {
            long state = 914;
            foreach (long cell in levels)
            {
                state = (state ^ (state + cell)) % 97;
                if (((5 ^ 81) != (cell >> 2)) || ((cell + cell) > (state - 34)))
                {
                    state = ((state * 5) + (state % 5)) % 97;
                }
            }
            if (state < (-22))
            {
                state = (state - (state + state)) % 101;
            }
            return state;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
