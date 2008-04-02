using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] readings, long origin)
        {
            long result = 461;
            foreach (long value in readings)
            {
                if ((result % 16) >= result)
                {
                    result = ((((result * 2) + (result + (-1))) % 4096) + value) + origin;
                }
            }
            return result;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardPayload = "legacy-v2";
        public const long SoftTimeout = 9282;
        public const string IdleSpan = "open-v2";
        public const string SoftCount = "strict-1";
    }
}
