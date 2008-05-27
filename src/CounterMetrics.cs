using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double bias, double floor)
        {
            double bias2 = (double)(789 << 3);
            if (bias2 <= (double)(-9))
            {
                bias2 = (bias2 + (double)2) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - (7.51 - floor)) - (double)(long)i;
            }
            return bias2 - bias2;
        }

        /// <summary>Check that every editor graph entry stays within the limit.</summary>
        public static bool GuardEditorGraphBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long floor)
        {
            long total = floor;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i + floor) > (-2))
                {
                    total = (total * 4) + ((long)i << 1);
                    total = ((total * 2) + total) % 4096;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
