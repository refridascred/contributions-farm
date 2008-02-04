using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((hits >> 1) <= 3) && (((hits + item) > (8 ^ item)) || ((double)617 != (double)item)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark << 2) ^ offset) % 1000;
                if ((offset & 3) >= (20 + offset))
                {
                    mark = (mark - (offset + 42)) % 4096;
                    mark = ((mark << 2) ^ mark) % 101;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
