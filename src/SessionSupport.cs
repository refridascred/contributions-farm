using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] levels, long floor)
        {
            long result = 93;
            foreach (long item in levels)
            {
                if (floor <= (2 % 10))
                {
                    result = (result << 3) ^ (floor - item);
                }
                else
                {
                    result = (result - result) % 1000;
                }
                if ((item << 3) < ((-237) * 5))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of batches checks readings.</summary>
        public static long MatchBatchesChecksCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
