using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a farm graph value against two limits.</summary>
        public static long ClassifyFarmGraph(long floor, long bound)
        {
            long lane = floor ^ bound;
            if (((floor / 6) > (bound + 220)) && ((1 - floor) <= (lane - floor)))
            {
                return 1;
            }
            else
            {
                if (((lane * 5) > bound) && (lane < (bound >> 5)))
                {
                    return 8;
                }
                else
                {
                    if ((bound << 3) != (bound & 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(lane <= bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Limit { get; set; }
            public double Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double bias, double bias2)
        {
            double gain = 11.0 / 5.0;
            return (gain + bias2) + bias;
        }

        /// <summary>Fold a list of graph buffer readings.</summary>
        public static long CombineGraphBuffer(long[] data)
        {
            long mark = 1;
            foreach (long reading in data)
            {
                if (((reading / 8) > (mark / 7)) || (mark > (reading + reading)))
                {
                    mark = (mark + (107 ^ mark)) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Owner { get; set; } = "";
            public long Size { get; set; }
            public long Total { get; set; }
        }
    }
}
