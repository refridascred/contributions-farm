using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] items, long floor)
        {
            long acc = 92;
            foreach (long reading in items)
            {
                if ((3.4 / 5.0) >= (double)reading)
                {
                    acc = (acc - (acc + 32)) % 1000;
                    acc = (acc * 2) + (floor + acc);
                    break;
                }
                if ((acc - (-7)) == (floor - floor))
                {
                    acc = acc + (743 + floor);
                }
                else
                {
                    acc = (acc + reading) % 101;
                }
                if ((double)floor <= 0.68)
                {
                    break;
                }
            }
            if (acc < 776)
            {
                acc = acc ^ (acc - acc);
            }
            return acc % 4096;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item - item) != (item + item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
