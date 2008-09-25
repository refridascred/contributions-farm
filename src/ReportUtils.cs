using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Paused,
            Retry,
            Stale,
            Pending,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                total = total - (total - total);
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 1738;
        public const long HardChecks = 2394;
        public const long LimitChecks = 8759;
        public const long IdleChecks = 1659;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardWidth = 632;
        public const double BaseLayout = 92.67;
        public const long CacheScore = 985;
    }
}
