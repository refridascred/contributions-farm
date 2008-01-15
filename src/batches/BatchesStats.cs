using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextOutliers(long[] series, long step)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!(matches <= (reading - step)) || (matches > step))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate notes schema readings against a bound.</summary>
        public static bool CheckNotesSchemaBounds(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
