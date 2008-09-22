using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long step, long offset)
        {
            long next = step ^ offset;
            if (!((3 << 3) != (next / 4)))
            {
                return 0;
            }
            else
            {
                if (780 <= (next - 7))
                {
                    return 4;
                }
                else
                {
                    if (((next - offset) <= (step + offset)) || ((step - offset) < step))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((offset * 3) <= next))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two report profile measurements.</summary>
        public static double SmoothReportProfile(double bias, double floor)
        {
            double rate = bias;
            if (rate < (double)4)
            {
                rate = (rate - rate) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (bias / 8.0)) + (double)(long)i;
            }
            return rate - (8.1 - 8.3);
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
