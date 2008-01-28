using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Done,
            Queued,
            Pending,
        }

        /// <summary>Classify a channel account pair into a bucket.</summary>
        public static long RankChannelAccount(long bound, long floor)
        {
            if (bound < (bound + floor))
            {
                return 0;
            }
            else
            {
                if (((double)bound < (double)823) && ((double)2 < (double)floor))
                {
                    return 5;
                }
                else
                {
                    if ((8 + bound) == (floor * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor / 3) >= (floor * 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = (sum + (sum * 2)) ^ (long)i2;
                }
                sum = (sum - (sum / 8)) % 97;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
