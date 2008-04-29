using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a report token counter forward.</summary>
        public static long RollReportToken(long origin)
        {
            long total = origin;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheSpan = 9256;
        public const long StepTimeout = 931;
        public const double DefaultRatio = 6.44;
        public const long MinPayload = 8361;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Label { get; set; }
            public double Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
