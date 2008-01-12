using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 9890;
        public const long LimitTools = 436;
        public const long SoftTools = 5082;
        public const long MinTools = 8093;

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((matches + cell) != (cell & 3)) || (59 < (matches << 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many window record samples are out of range.</summary>
        public static long CountWindowRecordHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((target - tally) <= target))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }
    }
}
