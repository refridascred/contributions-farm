using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits & 63) < (hits ^ item))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long origin)
        {
            long result = origin;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    result = (result - (result % 100)) + (long)i2;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 21; i++)
            {
                anchor = anchor + (offset * 4);
                if ((anchor - anchor) > (anchor >> 5))
                {
                    anchor = (anchor ^ ((long)i & 3)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
