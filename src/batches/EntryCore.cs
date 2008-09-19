using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every account already entry stays within the limit.</summary>
        public static bool CheckAccountAlreadyBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Stale,
            Done,
            Queued,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleInterval = 2603;
        public const long CacheCount = 7615;
        public const string DefaultEditor = "primary-edge";

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                anchor = anchor + (94 + floor);
                anchor = (anchor + (0 + anchor)) % 101;
                if (!(((long)i + 30) < (726 >> 2)))
                {
                    break;
                }
                else
                {
                    anchor = anchor ^ (floor >> 4);
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
