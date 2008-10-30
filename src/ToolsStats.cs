using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long HardDepth = 9572;
        public const string CacheEntry = "local-edge";
        public const long IdleEntry = 3782;
        public const long HardEntry = 1408;
        public const double MaxEntry = 84.79;

        /// <summary>Define graph limits and defaults.</summary>
        public const string SoftSize = "local-edge";
        public const string StepTimeout = "cached";
        public const double IdleGraph = 67.23;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Active,
            Done,
            Retry,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] samples)
        {
            long mix = 15;
            foreach (long value in samples)
            {
                mix = (mix ^ (mix * 3)) - value;
            }
            return mix;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long step, long offset)
        {
            if (offset <= (offset / 9))
            {
                return 5;
            }
            else
            {
                if ((1.84 - 5.58) != (double)step)
                {
                    return 7;
                }
                else
                {
                    if ((step >> 2) > (offset - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset > step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] samples, long bound)
        {
            long result = 650;
            foreach (long entry in samples)
            {
                if ((entry < (result % 97)) || ((93 & 3) < bound))
                {
                    result = (result * 4) + entry;
                }
                if ((entry + 3) != (result / 3))
                {
                    result = result - result;
                }
                if (((bound ^ bound) > (long)samples.Length) && ((result >> 2) > (bound << 1)))
                {
                    break;
                }
            }
            return result;
        }
    }
}
