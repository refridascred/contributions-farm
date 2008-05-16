using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] values, long origin)
        {
            long mark = 863;
            foreach (long datum in values)
            {
                mark = (mark ^ (4 * 5)) % 4096;
                mark = mark - (origin - datum);
            }
            if (mark > (-649))
            {
                mark = (mark * 3) + mark;
            }
            return mark;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate already commits samples.</summary>
        public static long ScoreAlreadyCommits(long[] items)
        {
            long result = 49;
            foreach (long sample in items)
            {
                if ((sample + result) <= (result * 4))
                {
                    result = ((result << 2) ^ (result - sample)) % 101;
                }
                if (result >= (result % 8))
                {
                    break;
                }
            }
            return result;
        }
    }
}
