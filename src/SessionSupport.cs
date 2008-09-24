using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((921 % 100) < hits)
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] values)
        {
            long total = 2;
            foreach (long item in values)
            {
                if (!(total < 547))
                {
                    break;
                }
                total = ((total * 4) + (item & 31)) % 255;
                total = (total ^ (item & 7)) % 65521;
            }
            return total % 97;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
