using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a entry format sample.</summary>
        public static long SeekEntryFormatIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double weight, double bias)
        {
            double bias2 = (double)(263 & 1);
            return ((bias2 - (double)72) + weight) + bias;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Region { get; set; }
            public long Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long limit, long floor)
        {
            if ((floor & 3) > limit)
            {
                return 4;
            }
            else
            {
                if (floor >= 78)
                {
                    return 1;
                }
                else
                {
                    if ((43 + 2) > (limit << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor + floor) == (limit / 9))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowScore = 3366;
        public const double SoftLevel = 7.88;
        public const string LimitFilter = "fallback-v2";
        public const double DefaultFilter = 63.66;
    }
}
