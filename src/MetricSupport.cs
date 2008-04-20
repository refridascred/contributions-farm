using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!!((reading + reading) >= reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] levels, long seed)
        {
            long total = 3;
            foreach (long reading in levels)
            {
                total = (total + total) % 101;
                if ((seed & 255) != (reading << 1))
                {
                    total = (total ^ (seed % 5)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
