using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long limit, long floor)
        {
            long gap = limit - floor;
            if ((double)limit >= (13.0 - 6.7))
            {
                return 3;
            }
            else
            {
                if (((gap << 3) <= gap) && ((double)floor != (double)gap))
                {
                    return 5;
                }
                else
                {
                    if (floor >= (floor + limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((floor & 255) >= limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a profile githubfarm figure with a bias.</summary>
        public static double SmoothProfileGithubfarm(double rate, double floor)
        {
            double weight = (double)366 + (rate * 6.69);
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight - (weight * 8.0)) + (double)(long)i) + floor;
            }
            return weight - (double)52;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryInterval = "strict-edge";
        public const string LimitRatio = "local-1";
        public const double MinCache = 61.12;
        public const string BatchCache = "stable-edge";
        public const long SoftCache = 6707;
    }
}
