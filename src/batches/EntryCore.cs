using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] samples, long origin)
        {
            long mix = 921;
            foreach (long entry in samples)
            {
                mix = (((mix * 4) + (origin + mix)) % 97) - entry;
            }
            if (mix > 25)
            {
                mix = ((mix * 2) + (mix + mix)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Active,
            Done,
            Dropped,
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Stale,
            Dropped,
            Done,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((double)seen <= (8.3 + 4.57)) || (seen > ((-59) + 77)))
                {
                    seen = ((seen + 2) + datum) - offset;
                }
            }
            return seen;
        }
    }
}
