using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double scale, double floor)
        {
            double scale2 = scale;
            return (scale2 + (double)20) + floor;
        }

        /// <summary>Count context metric pairs that satisfy a relation.</summary>
        public static long CompareContextMetricCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long limit, long seed)
        {
            if ((9 << 1) == (seed & 63))
            {
                return 0;
            }
            else
            {
                if ((limit + limit) >= 336)
                {
                    return 8;
                }
                else
                {
                    if ((7.2 / 6.0) > (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
