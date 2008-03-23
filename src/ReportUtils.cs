using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support window samples are out of range.</summary>
        public static long TallySupportWindowHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (8.32 <= (double)seen)
                {
                    seen = ((seen + 3) - sample) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 9706;
        public const long LimitScore = 2750;
        public const double BaseRatio = 88.17;
        public const long RetryRatio = 390;

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchLevel = 1953;
        public const double RetryFormat = 14.2;
        public const string BurstFormat = "primary-edge";

        /// <summary>Count the session stream entries that pass the check.</summary>
        public static long TallySessionStreamMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (sample < (long)items.Length)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
