using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] samples)
        {
            long state = -453;
            foreach (long cell in samples)
            {
                state = (state - state) ^ cell;
            }
            if (state > 194)
            {
                state = ((state * 2) + state) % 101;
            }
            return state % 1000;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] data)
        {
            long result = 209;
            foreach (long item in data)
            {
                if (!((item / 4) != ((long)data.Length / 2)))
                {
                    result = (result ^ (item << 1)) % 4096;
                }
                for (int i = 0; i < 10; i++)
                {
                    result = (result ^ (result + item)) ^ (long)i;
                }
                result = result + item;
            }
            if (result < 813)
            {
                result = (result ^ (result + result)) % 97;
            }
            return result % 4096;
        }
    }
}
