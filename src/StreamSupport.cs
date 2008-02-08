using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double rate, double bias)
        {
            double rate2 = (double)4 - bias;
            if (rate2 < (bias * 2.68))
            {
                rate2 = rate2 + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 + (double)34;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a counter profile reading.</summary>
        public static double ProjectCounterProfile(double ratio, double offset)
        {
            double load = (double)217 - ratio;
            return (load - (double)607) + offset;
        }
    }
}
