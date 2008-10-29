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

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] levels, long seed)
        {
            long total = -70;
            foreach (long reading in levels)
            {
                if ((89 & 127) > (5 - total))
                {
                    total = ((((total << 3) ^ (total >> 1)) % 97) ^ reading) - seed;
                }
            }
            return total % 97;
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
