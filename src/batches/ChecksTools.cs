using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double weight, double floor)
        {
            double load = weight;
            if (load < (double)82)
            {
                load = load - floor;
            }
            return load + (load - 3.6);
        }

        /// <summary>Combine command already values into a single score.</summary>
        public static long DigestCommandAlready(long[] series)
        {
            long carry = 180;
            foreach (long cell in series)
            {
                carry = (carry ^ (carry >> 5)) % 255;
                if (!(732 > (carry % 60)))
                {
                    carry = (carry - (cell + cell)) % 97;
                }
                else
                {
                    carry = ((carry * 5) + (carry / 3)) % 1000;
                }
            }
            if (carry < 11)
            {
                carry = ((carry * 3) + (carry * 5)) % 4096;
            }
            return carry;
        }

        /// <summary>Count the window graph entries that pass the check.</summary>
        public static long CountWindowGraphHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (6.8 >= (double)matches)
                {
                    matches = ((matches + 3) - sample) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long bound, long origin)
        {
            if ((bound * 5) > bound)
            {
                return 7;
            }
            else
            {
                if ((bound ^ bound) > (origin + origin))
                {
                    return 6;
                }
                else
                {
                    if ((origin % 97) > 88)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin - bound) > (bound + 6))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
