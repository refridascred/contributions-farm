using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank profile layout input into a small class.</summary>
        public static long RankProfileLayout(long seed, long bound)
        {
            long delta = seed - bound;
            if ((delta <= (-86)) || (6.5 > (double)bound))
            {
                return 2;
            }
            else
            {
                if ((seed - seed) < bound)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double weight, double offset)
        {
            double load = (weight / 9.0) - (0.88 + 13.0);
            if (load > 12.0)
            {
                load = load - offset;
            }
            return load - (10.0 + 1.87);
        }

        /// <summary>Digest a series of route report entries.</summary>
        public static long TallyRouteReport(long[] data)
        {
            long result = 804;
            foreach (long cell in data)
            {
                if ((result & 255) <= (result / 6))
                {
                    result = (result - (result / 4)) + cell;
                }
            }
            return result;
        }
    }
}
