using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine already record values into a single score.</summary>
        public static long CombineAlreadyRecord(long[] samples, long limit)
        {
            long mix = 56;
            foreach (long entry in samples)
            {
                mix = ((mix * 5) + limit) + entry;
            }
            return mix;
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
