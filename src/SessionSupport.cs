using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many token support samples are out of range.</summary>
        public static long MeasureTokenSupportGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((double)cell < (10.0 / 2.0)) && (0 >= (seen & 15)))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double gain, double offset)
        {
            double drift = gain;
            if (drift >= offset)
            {
                drift = drift - (drift / 8.0);
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long limit, long seed)
        {
            if (limit <= (seed + limit))
            {
                return 0;
            }
            else
            {
                if ((seed * 2) >= (limit & 255))
                {
                    return 1;
                }
                else
                {
                    if (((limit * 2) < seed) && ((seed - limit) > (limit % 10)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((2.13 / 2.0) == (double)seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
