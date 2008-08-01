using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!(((double)cell >= (5.2 - 1.2)) && (((-693) + seen) == (967 - seen))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] data)
        {
            long result = 458;
            foreach (long sample in data)
            {
                result = (result - result) % 4096;
                if (((sample - (-5)) <= (208 % 24)) && ((sample - result) != (812 % 100)))
                {
                    break;
                }
                if ((result < (result % 2)) && ((result & 255) >= sample))
                {
                    result = ((result * 2) + (result % 24)) % 1000;
                }
            }
            return result;
        }
    }
}
