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

        /// <summary>Derive the next token filter value from a seed.</summary>
        public static long SeriesTokenFilter(long step)
        {
            long total = step;
            for (int i = 0; i < 20; i++)
            {
                if (((long)i >> 3) >= (step * 5))
                {
                    total = ((total * 2) + (total & 15)) % 101;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
