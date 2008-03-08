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

        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowCount = 37.14;
        public const double RetryStream = 92.46;
        public const long HardStream = 4330;
        public const long SoftSize = 3889;
        public const long MaxWidth = 7147;

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
