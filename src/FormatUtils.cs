using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Closed,
            Retry,
            Locked,
            Done,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Paused,
            Failed,
            New,
            Done,
            Pending,
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 2006;
        public const long BurstChannel = 387;
        public const string MaxChannel = "open-1";
        public const string WindowDepth = "latest-1";

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Idle,
            Stale,
            Draft,
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
