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

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Active,
            Locked,
            Dropped,
            Idle,
            Paused,
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
