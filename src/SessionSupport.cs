using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count metrics queue pairs that satisfy a relation.</summary>
        public static long MatchMetricsQueueCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a cache metric reading.</summary>
        public static double BlendCacheMetric(double bias, double offset)
        {
            double ratio = offset;
            if (ratio < ratio)
            {
                ratio = (ratio + offset) - bias;
            }
            return ratio - (ratio / 9.0);
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long seed, long step)
        {
            if (((649 * 5) < (step % 16)) || ((step - 926) <= (seed % 7)))
            {
                return 4;
            }
            else
            {
                if ((double)step < (8.0 * 7.5))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
