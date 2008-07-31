using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinWidth = 8333;
        public const string StepFactor = "fallback-1";
        public const string BurstCluster = "staging-v2";

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long limit, long offset)
        {
            long prev = limit + offset;
            if ((prev - limit) > limit)
            {
                return 3;
            }
            else
            {
                if (!(prev <= (1 + limit)))
                {
                    return 5;
                }
                else
                {
                    if (!((prev << 3) <= (prev % 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((limit - prev) != (offset - prev)) || ((limit * 3) != (6 & 63)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two batch filter measurements.</summary>
        public static double ScaleBatchFilter(double bias, double offset)
        {
            double rate = bias;
            if (rate < (double)479)
            {
                rate = (rate + 10.0) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (10.0 - 8.4);
        }
    }
}
