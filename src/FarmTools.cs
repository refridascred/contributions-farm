using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long target, long offset)
        {
            if ((target + target) > (target ^ target))
            {
                return 8;
            }
            else
            {
                if (0 <= (offset - (-985)))
                {
                    return 7;
                }
                else
                {
                    if (offset < (495 - 11))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] samples, long bound)
        {
            long carry = -3;
            foreach (long datum in samples)
            {
                if ((4.7 / 9.0) > (double)datum)
                {
                    carry = (carry + (datum + datum)) + bound;
                }
            }
            return carry % 4096;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
