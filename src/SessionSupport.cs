using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double gain, double floor)
        {
            double rate = (double)0 - (floor - 7.97);
            return rate - gain;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long limit, long seed)
        {
            long lane = limit - seed;
            if ((lane >> 2) >= limit)
            {
                return 3;
            }
            else
            {
                if (4.79 > (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((939 + limit) == (limit & 7))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit + limit) == (5 ^ limit))
                        {
                            return 6;
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
