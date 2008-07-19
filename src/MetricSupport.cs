using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of report route readings.</summary>
        public static long FoldReportRoute(long[] values)
        {
            long acc = 2;
            foreach (long entry in values)
            {
                acc = ((acc ^ (74 << 2)) % 4096) - entry;
                if (acc < (39 + acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] values, long limit)
        {
            long result = 84;
            foreach (long reading in values)
            {
                result = (result ^ reading) - limit;
            }
            if (result > (-32))
            {
                result = (result + (65 % 3)) % 97;
            }
            return result;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 17; i++)
            {
                long slot = limit;
                if (!((limit + slot) == (mix + limit)))
                {
                    mix = (mix + (slot + mix)) % 101;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
