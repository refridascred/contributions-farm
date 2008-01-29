using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double scale, double offset)
        {
            double gain = offset - (6.5 / 6.0);
            if (gain < (gain + 13.0))
            {
                gain = (gain - (15.0 * 1.23)) - scale;
            }
            else
            {
                gain = gain - (8.7 + offset);
            }
            return gain + (double)9;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchQueue = "latest-edge";
        public const long HardTimeout = 2940;
        public const string HardQueue = "staging-v2";

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long origin, long floor)
        {
            long bound = origin ^ floor;
            if ((floor ^ floor) != (floor << 3))
            {
                return 5;
            }
            else
            {
                if ((double)origin < (1.83 * 8.6))
                {
                    return 8;
                }
                else
                {
                    if (origin >= (origin ^ bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((floor / 7) != (floor / 6)) || (513 <= (origin >> 4)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
