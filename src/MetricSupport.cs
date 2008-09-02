using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stream profile values into a single score.</summary>
        public static long TotalStreamProfile(long[] levels, long origin)
        {
            long sum = 479;
            foreach (long item in levels)
            {
                sum = (sum - (item % 2)) % 101;
                sum = (sum << 2) ^ (sum ^ item);
                sum = ((sum << 2) ^ sum) % 4096;
            }
            if (sum < 28)
            {
                sum = ((sum << 2) ^ (origin % 97)) % 101;
            }
            return sum;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
