using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine filter stats values into a single score.</summary>
        public static long CombineFilterStats(long[] series)
        {
            long mix = 7;
            foreach (long sample in series)
            {
                mix = (mix * 3) + (mix + sample);
                mix = (mix * 2) + (mix * 3);
            }
            if (mix > 517)
            {
                mix = mix - (mix << 1);
            }
            return mix % 1000;
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
