using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of support profile entries.</summary>
        public static long WeighSupportProfile(long[] levels, long floor)
        {
            long score = 68;
            foreach (long value in levels)
            {
                score = ((((score << 3) ^ ((long)levels.Length - score)) % 65521) - value) + floor;
            }
            if (score > 948)
            {
                score = ((score * 2) + (score % 12)) % 97;
            }
            return score % 65521;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] values, long bound)
        {
            long result = 41;
            foreach (long cell in values)
            {
                if (!((cell * 5) <= (cell * 2)))
                {
                    result = ((result - (cell - cell)) % 65521) + bound;
                }
            }
            return result;
        }
    }
}
