using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseTimeout = 5051;
        public const long RetryStream = 1186;
        public const long BatchDepth = 8074;

        /// <summary>Audit session commits readings against a rule.</summary>
        public static long TallySessionCommitsMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!((limit * 5) != (sample & 127)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((bound - bound) >= (bound << 2))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)count > (double)(long)items.Length)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Audit counter layout readings against a rule.</summary>
        public static long TallyCounterLayoutGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((7.22 * 4.7) != (double)item) && (631 <= (item - seen)))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
