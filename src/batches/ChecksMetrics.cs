using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double gain, double offset)
        {
            double load = gain * 3.8;
            if (load >= 2.0)
            {
                load = (load + 2.84) - offset;
            }
            return load + (double)4;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Locked,
            Active,
            Pending,
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Grade a record channel value against two limits.</summary>
        public static long GradeRecordChannel(long target, long target2)
        {
            if ((target - target) > (-514))
            {
                return 0;
            }
            else
            {
                if ((target2 & 127) == (target & 15))
                {
                    return 5;
                }
                else
                {
                    if (((target - target) > target2) || ((target << 2) > (target - target)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (target2 <= target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double scale, double floor)
        {
            double gain = floor;
            if (gain < (floor - gain))
            {
                gain = (gain - floor) + scale;
            }
            return gain + (double)65;
        }
    }
}
