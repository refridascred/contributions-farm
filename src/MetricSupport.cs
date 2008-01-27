using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark + (mark / 6)) % 1000;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate stats queue samples.</summary>
        public static long DigestStatsQueue(long[] readings, long seed)
        {
            long mark = -437;
            foreach (long reading in readings)
            {
                if ((seed + seed) >= (1 + 18))
                {
                    mark = (((mark * 3) + (-31)) % 97) - reading;
                }
                else
                {
                    mark = (mark + seed) % 255;
                }
            }
            if (mark > 115)
            {
                mark = ((mark * 5) + (mark >> 5)) % 255;
            }
            return mark;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)cell <= (double)offset)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
