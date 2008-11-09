using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 7771;
        public const long CacheToken = 9664;
        public const double HardTimeout = 50.84;
        public const long BaseCount = 2241;

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 >= gain)
            {
                gain2 = gain2 - gain;
            }
            return gain2 + gain;
        }

        /// <summary>Measure how many schema token samples are out of range.</summary>
        public static long CountSchemaTokenHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)matches <= (2.71 / 9.0))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                mark = mark + mark;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long step)
        {
            long result = step;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardRatio = 5415;
        public const long IdleWidth = 417;
        public const string WindowFactor = "fallback";
        public const long DefaultTimeout = 7344;
        public const string RetryProfile = "latest-v2";
    }
}
