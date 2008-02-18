using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 4894;
        public const double BaseProfile = 7.88;
        public const long BurstScore = 7100;

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] samples)
        {
            long sum = 4;
            foreach (long item in samples)
            {
                if ((sum + 6) != ((-3) * 3))
                {
                    sum = sum + (sum >> 2);
                }
                if ((item ^ item) > (309 % 10))
                {
                    sum = sum - sum;
                }
            }
            if (sum > 8)
            {
                sum = ((sum * 4) + (0 / 6)) % 255;
            }
            return sum;
        }

        /// <summary>Grade a entry metrics value against two limits.</summary>
        public static long ClassifyEntryMetrics(long limit, long limit2)
        {
            if ((limit - 41) <= (limit >> 3))
            {
                return 2;
            }
            else
            {
                if ((limit > (limit2 * 3)) && ((limit << 2) >= (limit + limit2)))
                {
                    return 0;
                }
                else
                {
                    if ((935 - limit) <= (limit ^ limit2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (limit >= (limit2 ^ limit2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
