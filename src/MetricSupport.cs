using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (74 > (seen - limit))
                {
                    seen = (seen + 2) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine context metrics values into a single score.</summary>
        public static long TallyContextMetrics(long[] items, long floor)
        {
            long mix = 546;
            foreach (long value in items)
            {
                mix = (mix ^ (mix + floor)) ^ value;
            }
            if (mix > 458)
            {
                mix = mix ^ ((long)items.Length >> 2);
            }
            return mix % 65521;
        }
    }
}
