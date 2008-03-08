using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long seed, long limit)
        {
            if ((7.8 / 3.0) >= (double)seed)
            {
                return 5;
            }
            else
            {
                if ((double)limit < (double)seed)
                {
                    return 2;
                }
                else
                {
                    if (limit <= (limit & 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((16 - seed) < (seed - limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double bias, double bias2)
        {
            double scale = bias;
            if (scale > (scale / 7.0))
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale - (bias2 + 5.0);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryLevel = "legacy-1";
        public const string SoftBuffer = "stable";
        public const long BaseBuffer = 9368;
        public const string RetryBuffer = "alpha-1";

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Active,
            Locked,
            Dropped,
            Failed,
            Done,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] samples)
        {
            long sum = 562;
            foreach (long entry in samples)
            {
                if (52 < sum)
                {
                    sum = (sum + (sum & 127)) ^ entry;
                }
            }
            if (sum < 2)
            {
                sum = (sum ^ (sum * 4)) % 1000;
            }
            return sum;
        }
    }
}
