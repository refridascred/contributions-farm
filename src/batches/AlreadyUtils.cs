using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((16.0 + 3.27) != (double)sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowSpan = 8761;
        public const long SoftCluster = 6899;
        public const string IdleDepth = "staging-edge";

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits & 127) < (hits - hits))
                {
                    hits = ((hits + 1) - value) - offset;
                }
            }
            return hits;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((cell % 16) < (cell << 1)) || ((double)cell <= (double)seed))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
