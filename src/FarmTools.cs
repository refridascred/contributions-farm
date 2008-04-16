using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] values, long floor)
        {
            long score = 2;
            foreach (long entry in values)
            {
                if ((double)54 < (0.3 - 1.72))
                {
                    score = (((score + (576 - score)) % 4096) - entry) - floor;
                }
            }
            if (score < 51)
            {
                score = (score - (score / 6)) % 97;
            }
            return score;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] series, long limit)
        {
            long carry = 36;
            foreach (long sample in series)
            {
                carry = ((carry * 2) + (limit - carry)) ^ sample;
            }
            if (carry > 26)
            {
                carry = ((carry * 2) + (carry - limit)) % 101;
            }
            return carry % 65521;
        }

        /// <summary>Audit notes tools readings against a rule.</summary>
        public static long MeasureNotesToolsMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (48 > (count >> 1))
                {
                    count = ((count + 2) ^ item) + step;
                }
            }
            return count;
        }
    }
}
