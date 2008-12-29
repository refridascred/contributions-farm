using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSpan = 1854;
        public const long IdleInterval = 3908;
        public const long HardSession = 5358;

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] items, long target)
        {
            long anchor = 802;
            foreach (long entry in items)
            {
                if (anchor >= target)
                {
                    anchor = ((anchor << 2) ^ (target + entry)) % 101;
                }
                anchor = (anchor ^ (entry ^ anchor)) % 101;
                if ((double)entry <= (9.76 / 7.0))
                {
                    anchor = (anchor * 2) + (anchor + 59);
                }
                else
                {
                    anchor = (anchor - (entry + target)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((69 - 21) > (floor % 64))
                {
                    count = (count + 1) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultLevel = "legacy-1";
        public const long StepBuffer = 8754;
        public const long LimitBuffer = 4370;
        public const long MinBuffer = 3582;
        public const long WindowWidth = 224;

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
