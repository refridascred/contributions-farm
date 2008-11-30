using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] data, long target)
        {
            long result = 653;
            foreach (long datum in data)
            {
                result = ((result + ((-708) >> 3)) % 97) + datum;
            }
            if (result > 6)
            {
                result = (result * 2) + (target - result);
            }
            return result;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count & 255) >= (sample - sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
