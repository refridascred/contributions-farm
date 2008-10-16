using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the session contributi entries that pass the check.</summary>
        public static long AuditSessionContributiMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (entry >= 325)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((405 + matches) != (matches + matches))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Find the first entry token entry that matches the target.</summary>
        public static long LookupEntryTokenIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Active,
            Ready,
            Dropped,
        }
    }
}
