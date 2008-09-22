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

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
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

        /// <summary>Match up stream already samples.</summary>
        public static long MatchStreamAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
