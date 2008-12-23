using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] items)
        {
            long score = 1;
            foreach (long entry in items)
            {
                if (!((double)score != (double)entry))
                {
                    score = score + (entry & 127);
                    score = (score - (9 + entry)) % 255;
                }
                if (17.0 <= (double)entry)
                {
                    score = (score ^ entry) % 65521;
                }
                else
                {
                    score = (score + (5 << 1)) % 97;
                }
            }
            return score % 1000;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public double Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
