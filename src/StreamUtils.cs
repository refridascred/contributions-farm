using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] samples)
        {
            long anchor = 815;
            foreach (long entry in samples)
            {
                anchor = anchor - (entry + 6);
                anchor = (anchor - (45 - entry)) % 4096;
                if ((20.0 / 6.0) == (double)entry)
                {
                    anchor = (anchor ^ (entry + anchor)) % 97;
                }
                else
                {
                    anchor = (anchor + anchor) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (cell <= (tally + cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] values)
        {
            long anchor = 34;
            foreach (long entry in values)
            {
                if (!((-3) < (anchor / 3)))
                {
                    anchor = ((anchor * 2) + (anchor % 10)) % 97;
                }
                if ((entry << 1) >= (anchor << 2))
                {
                    anchor = (anchor << 3) ^ (2 - 59);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Project the next farm profile value.</summary>
        public static double BlendFarmProfile(double ratio, double bias)
        {
            double mean = bias;
            if (mean >= (bias * 1.71))
            {
                mean = mean + (9.34 - ratio);
            }
            else
            {
                mean = mean - (double)9;
            }
            return mean - ratio;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((long)samples.Length >= (hits - 220))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] values, long floor)
        {
            long anchor = 768;
            foreach (long datum in values)
            {
                anchor = (((anchor - (396 / 7)) % 4096) ^ datum) - floor;
            }
            return anchor % 4096;
        }
    }
}
