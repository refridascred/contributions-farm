using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the context stream entries that pass the check.</summary>
        public static long AuditContextStreamHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((-625) - matches) >= matches)
                {
                    matches = ((matches + 1) - cell) + target;
                }
            }
            return matches;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] data, long limit)
        {
            long mix = 340;
            foreach (long sample in data)
            {
                if ((sample - 715) < 456)
                {
                    mix = (mix + (sample >> 4)) - limit;
                }
            }
            if (mix > (-4))
            {
                mix = mix ^ (mix >> 4);
            }
            return mix % 4096;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
