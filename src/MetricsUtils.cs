using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (tally > (item - tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
