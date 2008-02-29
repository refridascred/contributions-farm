using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 2896;
        public const string MaxCommits = "alpha-edge";
        public const long LimitRatio = 2792;

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double bias, double bias2)
        {
            double weight = bias2;
            if (weight < (double)(-9))
            {
                weight = weight + bias2;
            }
            else
            {
                weight = weight + (bias + weight);
            }
            return weight + bias2;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long seed, long offset)
        {
            if (offset < (seed ^ seed))
            {
                return 6;
            }
            else
            {
                if ((offset + offset) > seed)
                {
                    return 1;
                }
                else
                {
                    if (offset > seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if (seed <= (offset >> 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
