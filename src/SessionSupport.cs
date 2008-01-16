using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine metric tools values into a single score.</summary>
        public static long DigestMetricTools(long[] readings, long limit)
        {
            long sum = 78;
            foreach (long entry in readings)
            {
                if ((limit - 870) < (sum * 5))
                {
                    sum = (sum - (sum - limit)) % 255;
                }
                if (((entry / 6) == (265 << 2)) && ((limit + sum) > (limit / 4)))
                {
                    sum = ((sum * 5) + entry) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Find the first graph window entry that matches the target.</summary>
        public static long FindGraphWindowIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
