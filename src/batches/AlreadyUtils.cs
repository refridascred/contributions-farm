using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 14.43;
        public const string MinInterval = "local-1";
        public const string StepBuffer = "legacy-edge";

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Queued,
            Retry,
            Active,
            Stale,
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = (((acc * 5) + step) % 4096) ^ (long)i2;
                }
                if ((double)(long)i <= (16.0 - 6.45))
                {
                    acc = (acc + (long)i) % 101;
                }
                else
                {
                    acc = acc - (step & 255);
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                anchor = anchor - (floor << 3);
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Synced,
            Paused,
            New,
            Pending,
        }
    }
}
