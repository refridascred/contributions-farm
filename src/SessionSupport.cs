using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((4.58 / 4.0) > (double)reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

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
