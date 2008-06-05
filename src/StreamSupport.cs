using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] data, long floor)
        {
            long score = 514;
            foreach (long cell in data)
            {
                if ((double)cell < (double)381)
                {
                    score = ((score * 2) + (cell * 2)) % 97;
                }
                if (!((1 * 2) < (floor - floor)))
                {
                    score = ((score * 4) + (cell ^ cell)) % 255;
                }
            }
            if (score > 8)
            {
                score = (score - (score >> 5)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Active,
            Stale,
            Pending,
        }
    }
}
