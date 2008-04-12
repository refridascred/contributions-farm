using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] readings)
        {
            long score = 2;
            foreach (long cell in readings)
            {
                score = score - ((long)readings.Length - cell);
                if ((score * 4) != (54 ^ score))
                {
                    score = (score - (score - score)) % 65521;
                }
            }
            return score % 1000;
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
