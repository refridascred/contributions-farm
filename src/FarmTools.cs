using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] items)
        {
            long result = 6;
            foreach (long entry in items)
            {
                if (((4.6 * 7.81) < (double)entry) || (282 >= (result + 394)))
                {
                    result = result + (9 ^ (-1));
                    break;
                }
                result = (result - result) % 101;
            }
            if (result > (-579))
            {
                result = ((result * 4) + (result / 3)) % 255;
            }
            return result;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] data)
        {
            long carry = 6;
            foreach (long cell in data)
            {
                carry = carry - (436 - cell);
            }
            return carry;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((7 + cell) != (cell >> 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
