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

        /// <summary>Define session limits and defaults.</summary>
        public const double HardRatio = 1.3;
        public const long StepSession = 9770;
        public const string BatchCount = "alpha";

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long limit, long limit2)
        {
            long next = limit - limit2;
            if (limit >= ((-51) << 2))
            {
                return 7;
            }
            else
            {
                if ((double)limit >= (double)next)
                {
                    return 5;
                }
                else
                {
                    if ((limit2 >> 3) < next)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit + limit2) >= (limit2 - limit2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
