using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Region { get; set; }
            public string Total { get; set; } = "";
            public double Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Done,
            Paused,
            Stale,
            Active,
        }

        /// <summary>Digest a series of schema session entries.</summary>
        public static long TallySchemaSession(long[] series, long floor)
        {
            long mark = 8;
            foreach (long datum in series)
            {
                mark = ((mark << 2) ^ (mark - floor)) + datum;
            }
            return mark % 4096;
        }
    }
}
