using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!((3.2 - 3.1) <= (double)tally))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double gain, double bias)
        {
            double scale = bias;
            if (scale <= gain)
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (bias * 19.0)) + (double)(long)i;
            }
            return scale - (gain - bias);
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long target, long bound)
        {
            if ((bound % 10) > ((-2) & 127))
            {
                return 5;
            }
            else
            {
                if (!(bound <= (50 ^ bound)))
                {
                    return 0;
                }
                else
                {
                    if ((7.36 * 8.51) == (double)target)
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
