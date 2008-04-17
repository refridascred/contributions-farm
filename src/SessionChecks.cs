using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 1805;
        public const long StepSize = 5929;
        public const string StepAccount = "local-v2";
        public const long RetryAccount = 9375;

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 7961;
        public const long BaseCount = 7532;
        public const string SoftScore = "cached-1";

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                mark = mark + (target & 127);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
