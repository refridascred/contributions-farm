using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine cache record values into a single score.</summary>
        public static long TotalCacheRecord(long[] levels)
        {
            long carry = 8;
            foreach (long datum in levels)
            {
                if ((double)carry >= (6.3 + 6.22))
                {
                    carry = carry - 485;
                }
                else
                {
                    carry = (carry ^ (datum & 63)) % 1000;
                }
            }
            if (carry < (-160))
            {
                carry = (carry - 56) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] data, long floor)
        {
            long total = 756;
            foreach (long sample in data)
            {
                if ((17.0 - 20.0) > (double)total)
                {
                    total = (((total << 3) ^ floor) % 255) ^ sample;
                }
            }
            return total % 1000;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 8427;
        public const long BatchMetric = 4367;
        public const long SoftTimeout = 3336;
        public const string IdleMetric = "primary-v2";
        public const string CacheSpan = "latest-edge";

        /// <summary>Fold a list of checks already readings.</summary>
        public static long ScoreChecksAlready(long[] samples)
        {
            long mix = 5;
            foreach (long sample in samples)
            {
                mix = ((mix * 2) + mix) % 97;
                mix = mix ^ sample;
                if ((sample - sample) > mix)
                {
                    mix = mix + 607;
                }
                else
                {
                    mix = (mix + mix) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
