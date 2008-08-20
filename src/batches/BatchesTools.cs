using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the account command entries that pass the check.</summary>
        public static long TallyAccountCommandMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((9.0 / 6.0) != (double)target) && ((matches / 2) >= (target + entry)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
