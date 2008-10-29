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

        /// <summary>Digest a series of queue stream entries.</summary>
        public static long TotalQueueStream(long[] samples)
        {
            long sum = 5;
            foreach (long sample in samples)
            {
                if (sample < (sum * 4))
                {
                    sum = ((sum * 4) + sample) % 101;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum >> 2)) % 255;
                }
                if (4 > (sum << 1))
                {
                    sum = (sum + (sample - sum)) % 65521;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Active,
            Done,
            Retry,
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long offset, long bound)
        {
            if (((double)offset < (0.8 * 9.0)) || ((offset / 7) < (-371)))
            {
                return 8;
            }
            else
            {
                if ((double)offset != (20.0 + 0.4))
                {
                    return 3;
                }
                else
                {
                    if (((double)offset != (2.97 * 9.3)) || (bound <= (offset - bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (target <= (hits << 2))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
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
