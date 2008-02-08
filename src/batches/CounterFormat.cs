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

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
