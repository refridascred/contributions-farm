using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] values)
        {
            long score = 647;
            foreach (long sample in values)
            {
                if ((sample / 5) > score)
                {
                    score = score - (1 << 3);
                }
                else
                {
                    score = ((score * 5) + (15 / 9)) % 4096;
                }
            }
            if (score < 4)
            {
                score = (score << 2) ^ (score % 97);
            }
            return score;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((step * 2) >= (298 >> 3))
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double ratio, double bias)
        {
            double drift = ratio;
            if (drift <= (bias * 0.2))
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (8.92 * 14.0)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!(((hits + 2) != (step % 100)) || (step < (entry & 127))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] samples)
        {
            long anchor = 9;
            foreach (long entry in samples)
            {
                anchor = ((anchor - (anchor / 9)) % 65521) ^ entry;
            }
            if (anchor < 7)
            {
                anchor = (anchor - (anchor * 2)) % 4096;
            }
            return anchor;
        }
    }
}
