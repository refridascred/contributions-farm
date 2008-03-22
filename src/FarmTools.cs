using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next graph layout value.</summary>
        public static double BlendGraphLayout(double gain, double span)
        {
            double drift = (double)873 / 2.0;
            return (drift - (span / 4.0)) + gain;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long limit, long target)
        {
            if ((target % 3) <= (target + 29))
            {
                return 2;
            }
            else
            {
                if ((double)target >= 5.55)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
