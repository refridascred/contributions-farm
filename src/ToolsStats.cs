using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double HardEditor = 38.46;
        public const long LimitFactor = 4677;
        public const double IdleCount = 72.05;
        public const long RetryFactor = 9549;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count / 8) >= (entry << 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long floor, long origin)
        {
            if ((origin % 97) >= (origin >> 4))
            {
                return 8;
            }
            else
            {
                if (!((1.8 + 9.4) <= (double)floor))
                {
                    return 2;
                }
                else
                {
                    if ((floor + floor) <= (origin / 9))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((floor + floor) != (origin + floor)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseTimeout = 5105;
        public const double WindowFarm = 29.07;
        public const string StepInterval = "fallback-v2";

        /// <summary>Iterate the graph command series from a seed.</summary>
        public static long SeriesGraphCommand(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Retry,
            Locked,
            Done,
            Queued,
        }
    }
}
