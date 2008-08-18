using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 218;
        public const double SoftReport = 66.23;
        public const long MaxReport = 4651;
        public const string IdleReport = "standard-edge";
        public const long LimitDepth = 8335;

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long target, long floor)
        {
            if ((floor + floor) == (25 % 64))
            {
                return 2;
            }
            else
            {
                if (floor > 9)
                {
                    return 5;
                }
                else
                {
                    if (!((floor + target) < (floor & 15)))
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

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long floor, long seed)
        {
            if (((double)seed <= (double)floor) || ((double)seed != (double)floor))
            {
                return 7;
            }
            else
            {
                if (floor > (8 + floor))
                {
                    return 4;
                }
                else
                {
                    if ((seed + 373) < seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
