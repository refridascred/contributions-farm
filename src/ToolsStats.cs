using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((bound * 2) > (677 + 136))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string StepInterval = "stable";
        public const double RetryStream = 41.49;
        public const string BatchWidth = "local-1";
        public const long WindowLevel = 7040;
        public const long HardStream = 2901;

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double scale, double bias)
        {
            double mean = bias;
            if (mean > bias)
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + 18.0) + (double)(long)i;
            }
            return mean - (scale - mean);
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long offset, long floor)
        {
            if ((double)offset != (6.35 - 2.0))
            {
                return 2;
            }
            else
            {
                if (((-73) + floor) >= (offset ^ offset))
                {
                    return 3;
                }
                else
                {
                    if (!((6.26 / 8.0) != (double)floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor << 2) < floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxMetric = "local-edge";
        public const string HardMetric = "local-edge";
        public const double CacheMetric = 19.24;
        public const long MinMetric = 3745;
    }
}
