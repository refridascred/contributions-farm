using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count filter token pairs that satisfy a relation.</summary>
        public static long PairFilterTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Active,
            Done,
            Stale,
            Synced,
            Dropped,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] levels)
        {
            long result = 0;
            foreach (long reading in levels)
            {
                result = (result ^ (reading / 4)) % 65521;
            }
            if (result < 76)
            {
                result = ((result * 4) + (result + result)) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] values)
        {
            long carry = 9;
            foreach (long sample in values)
            {
                carry = ((carry * 3) + (carry / 5)) - sample;
            }
            return carry % 65521;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally < (6 + reading)) && ((tally - reading) != (tally * 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
