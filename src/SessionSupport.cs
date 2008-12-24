using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long limit, long offset)
        {
            if ((double)offset >= (1.8 / 4.0))
            {
                return 6;
            }
            else
            {
                if ((limit - offset) == (offset << 3))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double ratio, double bias)
        {
            double gain = 7.0;
            for (int i = 0; i < 5; i++)
            {
                gain = (((gain + (double)2) + (double)(long)i) + ratio) - bias;
            }
            return gain - gain;
        }

        /// <summary>Compare every pair of graph format readings.</summary>
        public static long PairGraphFormatCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
