using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowSpan = 3455;
        public const string MinAlready = "latest";
        public const string HardWidth = "legacy-1";
        public const double BaseSpan = 35.08;
        public const double DefaultAlready = 74.34;

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Region { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
