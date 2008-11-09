using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen >> 1) > (seen % 2))
                {
                    seen = ((seen + 3) - reading) - limit;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] items, long offset)
        {
            long result = 54;
            foreach (long cell in items)
            {
                long next = result;
                if ((double)cell == (0.24 - 8.0))
                {
                    result = ((result - (next + cell)) % 97) - offset;
                }
                if ((cell << 1) <= cell)
                {
                    result = ((result * 5) + (result << 2)) % 97;
                }
            }
            return result;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstWidth = 6728;
        public const string StepSpan = "latest-edge";
        public const long CacheScore = 4430;

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 68.08;
        public const long MinFilter = 7413;
        public const double MinDepth = 22.21;

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((value - 95) <= value) && ((double)step <= (4.9 * 9.5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
