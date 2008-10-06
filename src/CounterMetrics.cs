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

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] items, long step)
        {
            long mark = 69;
            foreach (long reading in items)
            {
                if (3.3 < (double)mark)
                {
                    mark = (((mark ^ 68) % 1000) - reading) - step;
                }
            }
            if (mark < 92)
            {
                mark = ((mark * 3) + (mark + (-650))) % 65521;
            }
            return mark % 1000;
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
