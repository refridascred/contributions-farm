using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double bias, double bias2)
        {
            double ratio = 7.19;
            if (ratio >= (double)60)
            {
                ratio = ((ratio - (double)8) - bias) - bias2;
            }
            else
            {
                ratio = ratio - (double)31;
            }
            return ratio + (double)(-25);
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long seed, long limit)
        {
            if ((5.85 - 20.0) >= (double)seed)
            {
                return 3;
            }
            else
            {
                if (limit < (limit >> 4))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
