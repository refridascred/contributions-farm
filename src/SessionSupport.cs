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

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long limit, long limit2)
        {
            if ((limit2 + limit2) >= (limit / 6))
            {
                return 4;
            }
            else
            {
                if (!((limit2 & 127) <= limit))
                {
                    return 7;
                }
                else
                {
                    if ((limit2 >= (4 % 60)) && ((double)limit2 < (double)56))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
