using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate command channel readings against a bound.</summary>
        public static bool GuardCommandChannelBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

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
