using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseSpan = 4762;
        public const long RetryBatch = 6118;
        public const long CacheBatch = 4192;

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] levels, long floor)
        {
            long sum = 73;
            foreach (long entry in levels)
            {
                if (((1.47 - 9.0) > (double)sum) && ((sum - 95) == (sum - 22)))
                {
                    sum = (((sum << 3) ^ sum) % 101) + entry;
                }
            }
            if (sum > 97)
            {
                sum = sum - (floor - sum);
            }
            return sum % 65521;
        }
    }
}
