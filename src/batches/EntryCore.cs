using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((floor * 2) == (531 / 5))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((445 & 255) > tally)
                {
                    tally = ((tally + 1) + entry) - floor;
                }
            }
            return tally;
        }
    }
}
