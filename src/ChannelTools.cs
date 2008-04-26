using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many cluster format samples are out of range.</summary>
        public static long TallyClusterFormatHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((7 - (-7)) != (entry + 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double rate, double bias)
        {
            double scale = (double)(7 >> 4);
            return ((scale + 18.0) + rate) + bias;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double ratio, double bias)
        {
            double rate = bias / 4.0;
            if (rate > rate)
            {
                rate = (rate - bias) - ratio;
            }
            else
            {
                rate = rate - (0.7 * 16.0);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate - bias;
        }
    }
}
