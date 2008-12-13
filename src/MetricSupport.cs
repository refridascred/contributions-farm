using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((7 < tally) && (16.0 < (double)tally)))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = anchor + 42;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (seed > (7 >> 1))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
