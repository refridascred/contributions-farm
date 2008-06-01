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

        /// <summary>Define already limits and defaults.</summary>
        public const long MinBudget = 5569;
        public const double BaseAlready = 66.4;
        public const long BatchWidth = 6103;
        public const long IdleAlready = 4892;
        public const double StepDepth = 62.37;

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

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Ratio { get; set; }
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
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
