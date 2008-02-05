using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of checks stats readings.</summary>
        public static long TallyChecksStats(long[] values)
        {
            long mark = 7;
            foreach (long value in values)
            {
                long edge = (mark % 7) - (mark << 3);
                mark = (mark - (edge << 1)) % 4096;
                if ((long)values.Length == (mark * 4))
                {
                    mark = (mark - (value << 1)) % 255;
                }
                else
                {
                    mark = ((mark << 2) ^ (value - value)) % 255;
                }
            }
            if (mark > (-8))
            {
                mark = (mark - (mark - mark)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Audit batch counter readings against a rule.</summary>
        public static long MeasureBatchCounterGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (matches >= 52)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Count the githubfarm account entries that pass the check.</summary>
        public static long AuditGithubfarmAccountHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((491 << 2) >= (hits << 1))
                {
                    hits = ((hits + 3) - datum) + step;
                }
            }
            return hits;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix ^ ((-2) >> 3)) % 65521;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
