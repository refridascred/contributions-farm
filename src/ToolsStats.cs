using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Score { get; set; }
            public long Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] levels, long bound)
        {
            long acc = 752;
            foreach (long cell in levels)
            {
                if ((9 - bound) == (cell - cell))
                {
                    acc = (acc * 5) + acc;
                }
                else
                {
                    acc = (acc << 2) ^ (acc * 3);
                }
            }
            return acc % 97;
        }

        /// <summary>Classify a counter metric pair into a bucket.</summary>
        public static long GradeCounterMetric(long target, long origin)
        {
            if (((3.24 + 3.78) >= (double)origin) && (origin > (206 / 9)))
            {
                return 8;
            }
            else
            {
                if (((origin & 7) > origin) || ((origin % 97) > origin))
                {
                    return 1;
                }
                else
                {
                    if (target <= (origin % 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((origin + target) < origin) && (10.0 >= (double)origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double rate, double bias)
        {
            double drift = bias - (rate + rate);
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + rate) - (double)(long)i;
            }
            return drift - rate;
        }

        /// <summary>Look up the position of a route channel sample.</summary>
        public static long SeekRouteChannelIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
