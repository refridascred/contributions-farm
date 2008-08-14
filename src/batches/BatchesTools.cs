using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Retry,
            Idle,
            Locked,
        }

        /// <summary>Compare every pair of payload checks readings.</summary>
        public static long PairPayloadChecksCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the notes record entries that pass the check.</summary>
        public static long TallyNotesRecordMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((double)matches != (4.87 / 4.0))
                {
                    matches = (matches + 2) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
