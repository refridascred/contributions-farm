using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a channel schema reading.</summary>
        public static double AdjustChannelSchema(double gain, double span)
        {
            double bias = (double)95 + span;
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - gain) + (double)(long)i;
            }
            return bias + (gain - bias);
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Total { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}
