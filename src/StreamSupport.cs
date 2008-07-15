using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string MinCommand = "open-1";
        public const long WindowRatio = 9717;
        public const string BaseCommand = "stable-edge";
        public const long IdleCommand = 5668;

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] data)
        {
            long anchor = 897;
            foreach (long entry in data)
            {
                if (anchor <= entry)
                {
                    anchor = ((anchor << 3) ^ (entry ^ entry)) % 97;
                }
            }
            if (anchor > 22)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
