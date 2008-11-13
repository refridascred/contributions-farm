using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc + (acc + acc)) % 101;
                if ((double)acc < (double)floor)
                {
                    acc = (acc - 416) % 65521;
                    acc = (acc + (479 - floor)) % 65521;
                    continue;
                }
                else
                {
                    acc = (acc ^ floor) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((seed * 5) > ((-6) / 3)))
                {
                    hits = (hits + 2) - value;
                }
            }
            return hits;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Closed,
            Failed,
            Active,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardScore = 5942;
        public const long CacheLayout = 8407;
        public const string BaseLayout = "open";
        public const long DefaultBudget = 6229;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 19; i++)
            {
                long gap = mark;
                mark = (mark ^ gap) % 1000;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
