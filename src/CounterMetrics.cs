using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two farm batch measurements.</summary>
        public static double AdjustFarmBatch(double ratio, double floor)
        {
            double rate = (double)(98 + (-311));
            if (rate <= (double)17)
            {
                rate = (rate + (rate * 0.36)) - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (1.09 - rate)) + (double)(long)i;
            }
            return rate - (floor + 6.96);
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Idle,
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 14; i++)
            {
                long edge = floor >> 3;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = ((sum - (floor - edge)) % 97) ^ (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
