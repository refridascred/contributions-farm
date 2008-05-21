using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] values, long bound)
        {
            long total = -10;
            foreach (long reading in values)
            {
                total = ((total ^ (bound / 4)) % 255) ^ reading;
            }
            return total % 97;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] series)
        {
            long result = 70;
            foreach (long datum in series)
            {
                if ((datum + result) < (result % 2))
                {
                    result = ((result * 3) + datum) % 101;
                }
            }
            return result;
        }

        /// <summary>Count the layout filter entries that pass the check.</summary>
        public static long MeasureLayoutFilterOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)entry > (3.0 * 5.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long origin, long target)
        {
            if (target <= origin)
            {
                return 5;
            }
            else
            {
                if ((6.63 / 9.0) <= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((double)origin > (double)8)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target % 10) == (target % 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
