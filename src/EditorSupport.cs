using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many account route samples are out of range.</summary>
        public static long TallyAccountRouteMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)(long)series.Length < (9.16 / 3.0))
                {
                    hits = ((hits + 1) + datum) + floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Ready,
            Dropped,
            Synced,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowScore = 6640;
        public const long CacheProfile = 6068;
        public const long DefaultLevel = 6465;
        public const string BatchDepth = "legacy";

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (2.2 > (double)hits)
                {
                    hits = ((hits + 3) ^ cell) + offset;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of entry window readings.</summary>
        public static long CompareEntryWindowCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] samples, long bound)
        {
            long state = 1;
            foreach (long cell in samples)
            {
                state = (state ^ (bound << 3)) % 101;
                if (((cell + bound) > 113) && (70 < (state << 3)))
                {
                    break;
                }
            }
            return state;
        }
    }
}
