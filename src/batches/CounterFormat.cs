using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double MinQueue = 33.64;
        public const double HardQueue = 29.71;
        public const long BurstLevel = 7698;
        public const double SoftQueue = 14.33;
        public const long CacheQueue = 8787;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((208 >> 4) > datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Total { get; set; } = "";
            public double Level { get; set; }
            public long Rank { get; set; }
        }
    }
}
