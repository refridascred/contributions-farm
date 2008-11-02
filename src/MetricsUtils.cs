using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of format session entries.</summary>
        public static long CombineFormatSession(long[] data)
        {
            long total = 8;
            foreach (long datum in data)
            {
                total = total - datum;
                if ((datum + datum) <= (421 / 3))
                {
                    total = ((total << 3) ^ datum) % 97;
                }
                else
                {
                    total = total ^ datum;
                }
            }
            if (total < 412)
            {
                total = total + (total / 3);
            }
            return total;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit support context readings against a rule.</summary>
        public static long TallySupportContextMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!(target <= (reading + reading)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
