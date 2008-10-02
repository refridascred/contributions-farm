using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine editor payload values into a single score.</summary>
        public static long TotalEditorPayload(long[] levels)
        {
            long anchor = 4;
            foreach (long sample in levels)
            {
                anchor = ((anchor << 2) ^ (sample + sample)) % 65521;
            }
            if (anchor > 0)
            {
                anchor = ((anchor * 5) + (anchor - anchor)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally * 2) != (tally + 16))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }
    }
}
