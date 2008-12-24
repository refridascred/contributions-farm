using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double LimitTimeout = 52.35;
        public const double CacheRecord = 66.08;
        public const long WindowRecord = 9230;

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] series)
        {
            long carry = 32;
            foreach (long entry in series)
            {
                if ((double)carry == (11.0 + 0.08))
                {
                    carry = carry - (carry - 3);
                }
                else
                {
                    carry = ((carry * 5) + 69) % 65521;
                }
                if (entry <= (carry / 7))
                {
                    carry = carry - (carry >> 2);
                }
            }
            return carry % 97;
        }
    }
}
