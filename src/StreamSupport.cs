using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
            public bool Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Size { get; set; }
            public long Score { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] levels, long bound)
        {
            long result = 59;
            foreach (long sample in levels)
            {
                result = (((result - ((long)levels.Length << 2)) % 1000) ^ sample) - bound;
            }
            return result;
        }
    }
}
