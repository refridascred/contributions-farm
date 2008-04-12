using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] series, long bound)
        {
            long total = 180;
            foreach (long sample in series)
            {
                total = (total - (sample / 5)) + bound;
            }
            if (total > 6)
            {
                total = (total + (total % 10)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long bound, long origin)
        {
            long diff = bound + origin;
            if ((59 % 5) <= (70 + diff))
            {
                return 5;
            }
            else
            {
                if ((double)diff < 11.0)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry << 3) ^ bound) % 255;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double scale, double span)
        {
            double mean = span;
            if (mean >= (4.93 / 3.0))
            {
                mean = mean - (scale / 7.0);
            }
            else
            {
                mean = mean + (mean / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - scale) - (double)(long)i;
            }
            return mean - (9.07 / 2.0);
        }
    }
}
