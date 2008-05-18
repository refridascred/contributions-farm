using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Total { get; set; }
            public double Score { get; set; }
        }

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
