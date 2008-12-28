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

        /// <summary>Check that every checks batch entry stays within the limit.</summary>
        public static bool VerifyChecksBatchRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
