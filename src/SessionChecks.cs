using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 346;
        public const long BatchBudget = 2198;
        public const string WindowScore = "primary-edge";
        public const long BaseSchema = 7623;
        public const string LimitSchema = "stable-1";

        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchNotes = 39.84;
        public const string MinFactor = "fallback-1";
        public const double DefaultDepth = 51.29;
        public const double RetryNotes = 2.4;
        public const long MaxNotes = 9915;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Roll a notes stream counter forward.</summary>
        public static long IterateNotesStream(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc << 3) ^ (acc % 5);
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
