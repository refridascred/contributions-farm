using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] samples)
        {
            long mix = 457;
            foreach (long cell in samples)
            {
                mix = ((mix << 2) ^ mix) ^ cell;
                if ((mix / 2) <= mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long origin, long floor)
        {
            if (floor > (origin ^ origin))
            {
                return 3;
            }
            else
            {
                if ((floor & 1) <= floor)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
