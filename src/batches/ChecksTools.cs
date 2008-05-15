using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinSize = "local-1";
        public const long SoftContributi = 3913;
        public const double DefaultInterval = 60.69;
        public const long WindowContributi = 1481;

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
