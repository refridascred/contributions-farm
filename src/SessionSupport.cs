using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a graph cache pair into a bucket.</summary>
        public static long SortGraphCache(long origin, long limit)
        {
            if ((1 / 6) < origin)
            {
                return 0;
            }
            else
            {
                if (origin < (limit << 3))
                {
                    return 1;
                }
                else
                {
                    if ((50 & 127) >= origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if (limit > (89 - 99))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a stream record pair into a bucket.</summary>
        public static long BucketStreamRecord(long bound, long floor)
        {
            if ((double)bound < (4.77 - 9.4))
            {
                return 8;
            }
            else
            {
                if (!((bound % 24) != (floor << 2)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double gain, double span)
        {
            double rate = (double)(74 + 13);
            if (rate >= (3.0 + rate))
            {
                rate = (rate - (gain + 8.3)) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + gain) - (double)(long)i;
            }
            return rate - 7.25;
        }
    }
}
