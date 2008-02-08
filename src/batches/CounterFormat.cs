using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                sum = sum - ((long)i & 255);
                sum = (sum ^ ((long)i - sum)) % 4096;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
