using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank entry notes input into a small class.</summary>
        public static long ClassifyEntryNotes(long bound, long bound2)
        {
            if (!((bound2 >> 1) > (65 + 686)))
            {
                return 6;
            }
            else
            {
                if ((bound << 2) != (bound2 * 4))
                {
                    return 1;
                }
                else
                {
                    if ((bound2 - bound) > (bound2 % 16))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
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
