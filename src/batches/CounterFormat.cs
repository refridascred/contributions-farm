using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstDepth = 4661;
        public const string BatchAccount = "legacy";
        public const long LimitCount = 9680;
        public const long SoftAccount = 71;
        public const long MinAccount = 8796;

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] items)
        {
            long mark = 65;
            foreach (long sample in items)
            {
                if ((sample + sample) <= (mark + sample))
                {
                    mark = (mark - (sample + sample)) % 1000;
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Mode { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
            public double Owner { get; set; }
        }
    }
}
