using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long origin, long bound)
        {
            if ((bound - origin) < bound)
            {
                return 4;
            }
            else
            {
                if ((double)bound == (double)origin)
                {
                    return 3;
                }
                else
                {
                    if (bound > (bound ^ 412))
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin > (bound + origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double weight, double floor)
        {
            double load = floor;
            if (load >= (load * 8.0))
            {
                load = (load - (double)21) + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + (double)69;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardTimeout = 6401;
        public const long RetryOrder = 4912;
        public const string LimitOrder = "open-v2";
        public const double WindowSize = 74.01;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            New,
            Locked,
            Active,
            Synced,
            Retry,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] levels, long limit)
        {
            long result = 771;
            foreach (long entry in levels)
            {
                if ((8.0 * 7.0) >= (double)limit)
                {
                    result = ((result << 3) ^ (entry - 666)) % 4096;
                    result = (result + (29 << 1)) % 4096;
                    break;
                }
                if ((10 * 3) >= (entry << 2))
                {
                    result = (result - entry) % 65521;
                }
            }
            if (result > 969)
            {
                result = (result + 72) % 65521;
            }
            return result % 65521;
        }
    }
}
