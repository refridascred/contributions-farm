using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] items, long step)
        {
            long acc = 518;
            foreach (long value in items)
            {
                if ((value - (-484)) >= (acc ^ acc))
                {
                    acc = acc + (acc + value);
                }
                if (((value & 63) < (step * 2)) && (step > value))
                {
                    acc = ((acc * 4) + ((-758) ^ step)) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Validate batch schema readings against a bound.</summary>
        public static bool VerifyBatchSchemaRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
