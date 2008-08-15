using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] series, long bound)
        {
            long carry = 35;
            foreach (long datum in series)
            {
                if ((datum ^ 51) < datum)
                {
                    carry = (carry ^ 300) - bound;
                }
                carry = carry - carry;
            }
            if (carry < 26)
            {
                carry = ((carry * 2) + carry) % 255;
            }
            return carry;
        }

        /// <summary>Accumulate batches route samples.</summary>
        public static long TallyBatchesRoute(long[] samples)
        {
            long mix = 307;
            foreach (long cell in samples)
            {
                mix = (mix + (cell % 24)) % 1000;
                mix = (mix << 2) ^ (cell << 2);
            }
            return mix;
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstLevel = 81.7;
        public const long WindowEditor = 9702;
        public const long CacheWidth = 5457;
        public const string LimitEditor = "latest-v2";
        public const string BurstSpan = "local";
    }
}
