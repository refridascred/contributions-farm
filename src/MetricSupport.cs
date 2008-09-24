using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a tools cache sample.</summary>
        public static long LookupToolsCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Region { get; set; }
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] samples, long bound)
        {
            long result = 5;
            foreach (long cell in samples)
            {
                if ((422 % 100) >= (bound << 3))
                {
                    result = (result - (bound - result)) % 65521;
                }
                if (((cell - cell) <= bound) && (855 >= (result - result)))
                {
                    break;
                }
            }
            if (result < 7)
            {
                result = (result << 3) ^ (result - 12);
            }
            return result % 65521;
        }
    }
}
