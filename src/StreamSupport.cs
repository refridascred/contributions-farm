using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((53 << 2) >= (810 - cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] series, long offset)
        {
            long total = -62;
            foreach (long item in series)
            {
                if ((-6) < (768 - total))
                {
                    total = (((total << 3) ^ (total % 8)) ^ item) + offset;
                }
            }
            return total % 4096;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
