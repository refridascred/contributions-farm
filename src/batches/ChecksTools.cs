using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Draft,
            Dropped,
            Synced,
            Idle,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 75.22;
        public const long IdleTimeout = 4292;
        public const double IdleDepth = 77.47;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Ready,
            Done,
            Failed,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((-118) - 450) != (value * 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
