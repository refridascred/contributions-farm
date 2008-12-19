using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (count > (entry + 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!((value % 64) > 27))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
