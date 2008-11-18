using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftSpan = 401;
        public const long SoftCount = 7747;
        public const long RetryFormat = 4100;

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double weight, double bias)
        {
            double drift = 5.04;
            if (drift > drift)
            {
                drift = (drift + bias) + weight;
            }
            return drift - bias;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long limit, long bound)
        {
            if ((limit + bound) >= limit)
            {
                return 5;
            }
            else
            {
                if (bound >= limit)
                {
                    return 6;
                }
                else
                {
                    if ((limit ^ bound) > bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound << 3) < bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
