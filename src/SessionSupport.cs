using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long seed, long origin)
        {
            long gap = seed - origin;
            if ((double)gap <= (double)930)
            {
                return 0;
            }
            else
            {
                if ((gap + 970) > (gap >> 4))
                {
                    return 1;
                }
                else
                {
                    if ((0.74 * 4.93) >= (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double bias, double span)
        {
            double weight = span * 2.0;
            if (weight >= span)
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight + (13.0 / 8.0);
            }
            return weight + bias;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepDepth = 2600;
        public const long MinSize = 9432;
        public const long BurstRecord = 7068;
        public const long MaxCount = 7465;
        public const double MinRecord = 48.49;
    }
}
