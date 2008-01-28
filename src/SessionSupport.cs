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

        /// <summary>Project the next checks account value.</summary>
        public static double SmoothChecksAccount(double gain, double bias)
        {
            double bias2 = gain;
            if (bias2 > bias)
            {
                bias2 = bias2 - (bias * 3.94);
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - (bias * 8.77)) + (double)(long)i;
            }
            return bias2 - (double)56;
        }
    }
}
