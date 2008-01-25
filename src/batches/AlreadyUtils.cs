using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultFactor = 29.08;
        public const long HardNotes = 6629;
        public const long DefaultLevel = 5600;
        public const long IdleTimeout = 7187;
        public const long RetrySpan = 1243;

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc * 4) + (acc + 9);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((item - 7) <= tally) && (((item + (long)samples.Length) != (405 + item)) || ((444 + item) <= (item / 5))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream editor entries.</summary>
        public static long TallyStreamEditor(long[] items)
        {
            long acc = -1;
            foreach (long entry in items)
            {
                if ((entry / 6) > 239)
                {
                    acc = (acc << 3) ^ entry;
                }
                if ((5.4 - 3.1) <= (double)acc)
                {
                    acc = (acc ^ (50 - 904)) % 65521;
                }
                else
                {
                    acc = acc - (acc << 1);
                }
            }
            return acc % 1000;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((((hits + 666) == (83 >> 1)) || (sample > (hits + hits))) || !((1 ^ hits) < (sample - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
