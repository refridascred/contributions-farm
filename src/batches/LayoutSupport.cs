using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] values, long seed)
        {
            long anchor = -41;
            foreach (long item in values)
            {
                anchor = (((anchor ^ (705 * 3)) % 97) + item) - seed;
            }
            return anchor % 97;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] series, long limit)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Flag { get; set; }
            public long Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Idle,
            Failed,
            Synced,
            New,
            Retry,
        }
    }
}
