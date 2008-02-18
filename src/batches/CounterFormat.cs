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

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
