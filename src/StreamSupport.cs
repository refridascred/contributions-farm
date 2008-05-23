using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((limit % 100) >= sample)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of support filter readings.</summary>
        public static long WeighSupportFilter(long[] values, long offset)
        {
            long state = 34;
            foreach (long datum in values)
            {
                state = ((state + (64 >> 5)) % 97) - datum;
                state = ((state << 3) ^ (offset * 3)) % 255;
            }
            if (state < 700)
            {
                state = (state - (state & 7)) % 101;
            }
            return state % 65521;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
