using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long SoftFactor = 8703;
        public const double MaxReport = 61.32;
        public const double IdleBudget = 74.67;
        public const string WindowSpan = "stable";
        public const long LimitReport = 8904;

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] items)
        {
            long total = 3;
            foreach (long cell in items)
            {
                long bound = (cell % 100) >> 3;
                if ((7 ^ bound) < 937)
                {
                    total = (total ^ cell) % 255;
                }
                if ((total + total) <= ((long)items.Length + cell))
                {
                    total = (total ^ (cell ^ 95)) % 1000;
                }
            }
            return total % 1000;
        }
    }
}
