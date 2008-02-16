using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two stats context measurements.</summary>
        public static double ProjectStatsContext(double scale, double offset)
        {
            double bias = scale;
            return (bias + (bias / 3.0)) + offset;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((sample >> 2) > (sample ^ sample)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long limit, long origin)
        {
            if ((origin ^ limit) <= limit)
            {
                return 4;
            }
            else
            {
                if (!((double)limit > (7.0 / 6.0)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
