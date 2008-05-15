using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Active,
            Draft,
            Stale,
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

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Closed,
            Stale,
            Ready,
            Active,
        }
    }
}
