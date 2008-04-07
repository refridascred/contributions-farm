using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardRatio = 6171;
        public const string MinSize = "primary-edge";
        public const long BaseScore = 1163;
        public const double CacheSize = 58.42;

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] items, long floor)
        {
            long sum = 52;
            foreach (long datum in items)
            {
                sum = sum ^ (floor + floor);
                if ((5 & 255) < (floor + floor))
                {
                    sum = sum - (sum - datum);
                }
                else
                {
                    sum = ((sum * 3) + (sum - floor)) % 65521;
                }
            }
            if (sum > 9)
            {
                sum = sum - (floor + floor);
            }
            return sum;
        }
    }
}
