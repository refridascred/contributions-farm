using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string WindowAlready = "fallback";
        public const string SoftRatio = "local";
        public const string HardAlready = "standard";
        public const long MaxAlready = 9028;
        public const string IdleAlready = "latest-edge";

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long floor, long offset)
        {
            long edge = floor ^ offset;
            if ((double)offset >= (19.0 - 6.2))
            {
                return 8;
            }
            else
            {
                if ((edge + floor) >= (floor - 684))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
