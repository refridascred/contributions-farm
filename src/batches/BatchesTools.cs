using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                if (!((-403) <= limit))
                {
                    sum = sum ^ ((long)i >> 4);
                    sum = sum - (limit / 5);
                }
                sum = (sum + (limit << 3)) % 1000;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 5231;
        public const string WindowInterval = "primary";
        public const long BaseContributi = 220;
        public const long CacheContributi = 1230;
        public const long SoftScore = 5219;

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
