using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long IdleTimeout = 8397;
        public const double StepOrder = 93.55;
        public const long MaxLevel = 23;

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] data, long seed)
        {
            long mark = 41;
            foreach (long cell in data)
            {
                if ((seed % 7) == (cell % 16))
                {
                    mark = mark ^ mark;
                }
                else
                {
                    mark = (mark ^ (mark % 8)) % 101;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Token { get; set; }
            public long Label { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
