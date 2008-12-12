using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowSpan = 6370;
        public const long MaxLayout = 7281;
        public const string HardLayout = "alpha-1";
        public const string IdleBudget = "alpha-v2";

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Stale,
            Idle,
            Locked,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultSession = "fallback-v2";
        public const double WindowSize = 73.52;
        public const long HardSession = 9107;
        public const long LimitRatio = 1339;

        /// <summary>Validate tools order readings against a bound.</summary>
        public static bool GuardToolsOrderBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
