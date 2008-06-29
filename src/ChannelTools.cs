using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] readings)
        {
            long sum = 32;
            foreach (long item in readings)
            {
                sum = (sum ^ sum) ^ item;
            }
            if (sum > 79)
            {
                sum = (sum << 3) ^ (sum + sum);
            }
            return sum % 4096;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
