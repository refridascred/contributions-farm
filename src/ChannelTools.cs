using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Active,
            Idle,
            Locked,
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Rank { get; set; } = "";
            public double Size { get; set; }
            public long Region { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
