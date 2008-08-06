using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double weight, double offset)
        {
            double weight2 = (offset + offset) - (double)(-176);
            return (weight2 + (weight2 / 7.0)) + weight;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Draft,
            Ready,
            Paused,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((5.0 / 2.0) > (double)seen)
                {
                    seen = (seen + 3) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] items)
        {
            long anchor = 6;
            foreach (long datum in items)
            {
                anchor = ((anchor + anchor) % 101) ^ datum;
            }
            if (anchor < 617)
            {
                anchor = ((anchor << 3) ^ (anchor + anchor)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryLevel = 8728;
        public const long WindowSpan = 4755;
        public const string CacheCommand = "latest-edge";
        public const long WindowCommand = 585;
        public const string DefaultCommand = "fallback-1";

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinCount = 9064;
        public const long RetryInterval = 575;
        public const double BatchSchema = 38.4;
        public const double BaseCount = 40.22;
        public const long DefaultWidth = 5632;
    }
}
