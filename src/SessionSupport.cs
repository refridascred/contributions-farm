using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every token command entry stays within the limit.</summary>
        public static bool ValidateTokenCommandBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long limit, long bound)
        {
            if ((bound + bound) == (bound << 3))
            {
                return 5;
            }
            else
            {
                if ((limit + limit) <= bound)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
