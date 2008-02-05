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

        /// <summary>Scale a metric payload figure with a bias.</summary>
        public static double AdjustMetricPayload(double bias, double span)
        {
            double ratio = (bias + bias) / 3.0;
            if (ratio <= span)
            {
                ratio = ratio + (bias / 5.0);
            }
            else
            {
                ratio = ratio + (double)609;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio - (7.6 * 5.1);
        }
    }
}
