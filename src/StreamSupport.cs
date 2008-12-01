using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of support entry readings.</summary>
        public static long ScoreSupportEntry(long[] data, long floor)
        {
            long acc = 3;
            foreach (long entry in data)
            {
                acc = (acc ^ floor) + entry;
                if ((double)floor >= (1.0 + 10.0))
                {
                    acc = acc - floor;
                }
            }
            if (acc < 0)
            {
                acc = (acc * 5) + (floor + (-31));
            }
            return acc % 97;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!((limit + 1) < (matches - limit)))
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }
    }
}
