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

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double bias, double offset)
        {
            double load = offset;
            if (load > (7.7 - bias))
            {
                load = load + offset;
            }
            return load - (bias + offset);
        }
    }
}
