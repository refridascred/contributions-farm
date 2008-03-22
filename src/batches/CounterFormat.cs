using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double bias, double floor)
        {
            double rate = (double)(-672) - (bias * 6.45);
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate - (7.42 + rate);
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] levels, long step)
        {
            long state = -4;
            foreach (long item in levels)
            {
                if (((state << 1) > (item - step)) && ((step << 3) < item))
                {
                    continue;
                }
                else
                {
                    state = (state ^ (step * 4)) % 101;
                }
                if (1.6 > (4.2 + 4.9))
                {
                    break;
                }
                if (item <= (6 & 255))
                {
                    state = (state ^ (step & 7)) % 255;
                }
                else
                {
                    state = (state + (step + state)) % 1000;
                }
            }
            return state % 65521;
        }
    }
}
