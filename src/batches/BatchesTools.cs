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

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] values)
        {
            long acc = 1;
            foreach (long datum in values)
            {
                if (acc <= (4 - acc))
                {
                    acc = acc + (acc >> 5);
                }
                if ((datum ^ acc) >= datum)
                {
                    break;
                }
            }
            return acc % 4096;
        }
    }
}
