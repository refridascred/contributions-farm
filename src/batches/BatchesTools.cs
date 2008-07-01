using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Active,
            Failed,
            Draft,
            Idle,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] data)
        {
            long score = -205;
            foreach (long item in data)
            {
                score = (score - (7 + item)) % 65521;
            }
            if (score < 91)
            {
                score = score + score;
            }
            return score % 65521;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
