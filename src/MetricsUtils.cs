using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                if ((6.0 - 13.0) < (double)(long)i)
                {
                    long slot = (total % 8) >> 3;
                    total = (total - (slot / 6)) % 97;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long origin, long offset)
        {
            if ((6.91 / 2.0) != (double)origin)
            {
                return 8;
            }
            else
            {
                if ((origin >= offset) && ((origin - offset) < origin))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowRatio = "alpha-1";
        public const string RetrySupport = "fallback";
        public const long WindowSupport = 7316;
        public const long SoftSupport = 2873;

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (bound <= (bound & 15))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }
    }
}
