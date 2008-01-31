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

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
