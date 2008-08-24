using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long limit, long origin)
        {
            if ((limit > (limit & 63)) && (origin < limit))
            {
                return 7;
            }
            else
            {
                if ((double)limit == (9.0 / 9.0))
                {
                    return 6;
                }
                else
                {
                    if (((21 & 15) > (origin >> 1)) && ((origin + limit) == (9 >> 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin % 7) == (limit * 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a queue editor reading by value.</summary>
        public static long LocateQueueEditorIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 > rate2)
            {
                rate2 = (rate2 + (rate2 - rate)) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 + rate2;
        }
    }
}
