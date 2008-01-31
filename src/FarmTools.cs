using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] series)
        {
            long mark = 27;
            foreach (long item in series)
            {
                mark = (mark ^ (item & 255)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Blend two tools schema measurements.</summary>
        public static double SmoothToolsSchema(double weight, double bias)
        {
            double bias2 = bias + (weight - bias);
            return bias2 - (bias2 * 4.9);
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long origin, long step)
        {
            long slot = origin - step;
            if ((double)slot < 5.7)
            {
                return 1;
            }
            else
            {
                if (!((step >> 2) < (origin * 3)))
                {
                    return 4;
                }
                else
                {
                    if (origin >= (7 + slot))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(2 >= (origin + step)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
