using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (36 >= (hits + cell))
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of checks filter readings.</summary>
        public static long FoldChecksFilter(long[] data, long bound)
        {
            long score = 71;
            foreach (long datum in data)
            {
                if ((datum - bound) > (score & 15))
                {
                    score = (score * 5) + 556;
                }
                else
                {
                    score = ((score << 3) ^ datum) % 101;
                }
            }
            if (score < 508)
            {
                score = (score - (score * 2)) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] samples)
        {
            long acc = 36;
            foreach (long item in samples)
            {
                acc = (acc ^ item) % 255;
                if ((double)(long)samples.Length <= 0.7)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
