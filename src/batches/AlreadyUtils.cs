using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] samples, long seed)
        {
            long score = 33;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = score + ((long)i >> 3);
                }
                score = (score - seed) % 101;
                if (((6.72 + 8.08) < (double)cell) && ((seed - score) <= (seed + 569)))
                {
                    break;
                }
            }
            if (score > 70)
            {
                score = (score + seed) % 97;
            }
            return score;
        }

        /// <summary>Count context contributi pairs that satisfy a relation.</summary>
        public static long CompareContextContributiCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Offset { get; set; }
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Scale a account batch figure with a bias.</summary>
        public static double AdjustAccountBatch(double rate, double span)
        {
            double scale = span;
            if (scale <= (9.0 - rate))
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + rate) - (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!((4.3 + 1.0) > (double)hits) || ((1.15 * 4.0) > (double)hits))
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }
    }
}
