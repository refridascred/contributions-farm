using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double rate, double span)
        {
            double ratio = (double)((-88) - (-7));
            if (ratio > (5.0 * 1.0))
            {
                ratio = (ratio + span) - rate;
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (ratio / 3.0)) - (double)(long)i;
            }
            return ratio + (double)436;
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double rate, double offset)
        {
            double mean = (double)6 * 2.27;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - (rate * 11.0)) + (double)(long)i) + offset;
            }
            return mean - (double)8;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
