using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long target, long floor)
        {
            if (((double)floor != (4.7 - 5.4)) || (10.0 <= (double)floor))
            {
                return 4;
            }
            else
            {
                if (((floor << 2) == (96 / 9)) || ((double)target != (20.0 / 2.0)))
                {
                    return 6;
                }
                else
                {
                    if (floor <= (target + target))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((0 + target) >= (0 + floor)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Rank { get; set; }
            public string Size { get; set; } = "";
            public double Region { get; set; }
            public double Weight { get; set; }
        }
    }
}
