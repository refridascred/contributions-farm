using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Label { get; set; }
            public double Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 4297;
        public const string IdleReport = "fallback";
        public const string MinReport = "legacy-1";
        public const long MaxReport = 796;
        public const long SoftReport = 1176;

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
