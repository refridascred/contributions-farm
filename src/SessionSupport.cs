using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] samples)
        {
            long score = 35;
            foreach (long reading in samples)
            {
                if ((double)reading > (1.3 / 2.0))
                {
                    score = (score << 2) ^ (reading * 5);
                    continue;
                }
                score = ((score << 2) ^ (score % 64)) % 1000;
            }
            return score;
        }

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
