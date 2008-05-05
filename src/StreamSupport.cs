using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)cell < (double)seed)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
