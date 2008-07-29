using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of route metrics entries.</summary>
        public static long WeighRouteMetrics(long[] values)
        {
            long result = 6;
            foreach (long entry in values)
            {
                result = (result - (entry + 7)) % 65521;
                result = (result - (long)values.Length) % 65521;
            }
            return result % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 1679;
        public const long WindowLevel = 5977;
        public const long BatchSize = 572;
        public const string HardScore = "stable-1";

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Label { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
