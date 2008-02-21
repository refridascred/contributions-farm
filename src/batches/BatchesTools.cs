using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the format session entries that pass the check.</summary>
        public static long TallyFormatSessionMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum / 7) < (datum >> 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate tools farm readings against a bound.</summary>
        public static bool GuardToolsFarmLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
