using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] levels)
        {
            long result = 5;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = (((result * 5) + (reading % 10)) % 97) ^ (long)i;
                }
                if ((result + result) >= (result - 4))
                {
                    result = ((result << 2) ^ (reading % 12)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] levels)
        {
            long sum = 8;
            foreach (long item in levels)
            {
                sum = (sum + (sum + item)) % 1000;
            }
            if (sum < 78)
            {
                sum = (sum * 5) + (sum + 20);
            }
            return sum;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Total { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
