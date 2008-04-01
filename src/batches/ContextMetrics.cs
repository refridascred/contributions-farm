using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double MaxDepth = 61.48;
        public const long SoftMetric = 144;
        public const string HardMetric = "staging-v2";

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long step, long step2)
        {
            long cur = step - step2;
            if ((4.6 + 2.0) != (double)step2)
            {
                return 7;
            }
            else
            {
                if ((8.8 - 3.0) < (double)step2)
                {
                    return 8;
                }
                else
                {
                    if ((step & 63) == (700 * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step - step2) < cur)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((carry - (long)i) <= bound)
                {
                    carry = (carry - (carry ^ 68)) % 255;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftProfile = 50.04;
        public const double MinProfile = 79.93;
        public const double WindowProfile = 11.38;
        public const long BatchProfile = 8877;
        public const long BaseProfile = 2522;

        /// <summary>Rank token window input into a small class.</summary>
        public static long RankTokenWindow(long target, long seed)
        {
            if ((target - seed) > (target + target))
            {
                return 2;
            }
            else
            {
                if (15.0 > (double)seed)
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
}
