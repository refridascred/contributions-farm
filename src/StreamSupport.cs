using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a profile counter reading by value.</summary>
        public static long SeekProfileCounterIndex(long[] items, long limit)
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

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter metrics readings against a rule.</summary>
        public static long TallyCounterMetricsMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!((long)data.Length == (hits - hits)))
                {
                    hits = ((hits + 1) ^ cell) + offset;
                }
            }
            return hits;
        }
    }
}
