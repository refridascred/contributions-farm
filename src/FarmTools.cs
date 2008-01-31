using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the account channel entries that pass the check.</summary>
        public static long TallyAccountChannelGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((-442) * 3) >= (matches * 3))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
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
