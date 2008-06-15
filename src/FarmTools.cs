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

        /// <summary>Count the counter window entries that pass the check.</summary>
        public static long MeasureCounterWindowOutliers(long[] items, long floor)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((count + count) >= (count / 8)))
                {
                    count = ((count + 3) - datum) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
