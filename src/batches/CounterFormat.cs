using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long offset, long limit)
        {
            if ((limit / 9) <= limit)
            {
                return 7;
            }
            else
            {
                if ((double)offset <= (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (((limit << 2) > offset) && ((-91) <= limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double ratio, double bias)
        {
            double rate = (bias * 8.7) + (ratio / 8.0);
            return rate + bias;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] values, long limit)
        {
            long mix = 43;
            foreach (long entry in values)
            {
                mix = ((mix << 2) ^ (limit ^ limit)) + entry;
            }
            if (mix > 34)
            {
                mix = (mix - (mix & 255)) % 101;
            }
            return mix % 65521;
        }
    }
}
