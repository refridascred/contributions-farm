using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (count > (step * 4))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
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
