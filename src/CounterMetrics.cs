using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine account contributi values into a single score.</summary>
        public static long ScoreAccountContributi(long[] samples, long floor)
        {
            long acc = 6;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = (acc + (long)i) % 97;
                }
                if (((double)acc <= (9.5 + 11.0)) || ((acc + entry) >= (floor * 2)))
                {
                    acc = ((acc * 3) + (floor ^ acc)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double ratio, double span)
        {
            double drift = (double)(749 >> 5);
            if (drift <= (ratio / 5.0))
            {
                drift = (drift - 8.2) + span;
            }
            else
            {
                drift = drift + (double)9;
            }
            return drift + drift;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (16.0 <= (double)hits)
                {
                    hits = ((hits + 2) - value) - target;
                }
            }
            return hits;
        }
    }
}
