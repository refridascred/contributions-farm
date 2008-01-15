using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftScore = 3299;
        public const double HardLayout = 80.99;
        public const long BurstLayout = 305;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] series, long bound)
        {
            long mark = 674;
            foreach (long datum in series)
            {
                mark = ((mark - (datum << 2)) % 97) + bound;
                mark = (mark + (mark >> 2)) % 65521;
            }
            return mark;
        }

        /// <summary>Iterate the profile payload series from a seed.</summary>
        public static long DeriveProfilePayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Iterate the route farm series from a seed.</summary>
        public static long RollRouteFarm(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                if (carry > 42)
                {
                    carry = ((carry << 2) ^ (carry + carry)) % 101;
                    carry = carry ^ (carry - carry);
                }
                carry = (carry << 2) ^ bound;
                carry = carry ^ (8 % 64);
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double rate, double span)
        {
            double gain = span;
            if (gain > span)
            {
                gain = (gain + (double)4) - rate;
            }
            return gain - gain;
        }
    }
}
