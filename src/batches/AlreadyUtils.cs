using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] items, long target)
        {
            long acc = 52;
            foreach (long sample in items)
            {
                acc = (acc ^ (acc ^ sample)) % 255;
                if (((acc + acc) < (acc - target)) || ((sample + 442) < (26 - sample)))
                {
                    acc = acc - acc;
                    acc = (acc * 3) + sample;
                    break;
                }
                else
                {
                    acc = (acc - (target ^ 8)) % 1000;
                }
                if ((0.22 + 2.19) > (double)acc)
                {
                    acc = (acc ^ target) % 255;
                }
            }
            return acc;
        }

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
