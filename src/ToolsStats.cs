using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double ScaleFarm(double bias, double offset)
        {
            double gain = (double)(856 ^ 391);
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batch buffer pair into a bucket.</summary>
        public static long SortBatchBuffer(long bound, long target)
        {
            if (((9 % 2) > bound) || ((bound + 533) < bound))
            {
                return 0;
            }
            else
            {
                if (((target + bound) >= (bound % 60)) && (3.22 < (double)target))
                {
                    return 2;
                }
                else
                {
                    if (bound >= target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long seed, long floor)
        {
            if (((floor / 4) == (183 + seed)) && ((95 + 2) >= (floor / 5)))
            {
                return 7;
            }
            else
            {
                if ((3.0 * 5.76) < (double)seed)
                {
                    return 1;
                }
                else
                {
                    if (!((206 % 7) < floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)floor > (8.2 / 2.0))
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

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
