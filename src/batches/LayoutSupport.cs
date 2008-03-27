using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] readings)
        {
            long sum = 6;
            foreach (long value in readings)
            {
                sum = sum + (value * 3);
                sum = ((sum << 3) ^ sum) % 97;
                sum = ((sum << 3) ^ (value + 11)) % 1000;
            }
            return sum;
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
