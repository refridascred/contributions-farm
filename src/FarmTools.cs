using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((((seen << 1) >= (seen - origin)) || ((value + 1) != (78 & 127))) || (value > (seen + origin)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((8.5 + 3.6) != (double)matches)
                {
                    matches = ((matches + 1) + value) - target;
                }
            }
            return matches;
        }
    }
}
