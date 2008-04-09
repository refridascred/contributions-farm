using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((2.6 / 7.0) <= (double)count) && (datum < count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((4.49 - 18.0) == (double)item)
                {
                    hits = (hits + 3) - bound;
                }
            }
            return hits;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix ^ (target % 12)) % 101;
                mix = (mix << 3) ^ ((long)i - target);
                mix = mix + ((long)i + target);
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
