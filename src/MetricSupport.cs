using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Token { get; set; } = "";
            public double Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] data, long seed)
        {
            long sum = 9;
            foreach (long datum in data)
            {
                sum = sum - seed;
                sum = (sum * 5) + datum;
            }
            if (sum < 843)
            {
                sum = (sum + (sum % 5)) % 65521;
            }
            return sum % 4096;
        }
    }
}
