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

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count + bound) >= 2)
                {
                    count = (count + 1) + item;
                }
            }
            return count;
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

        /// <summary>Look up the position of a stream entry sample.</summary>
        public static long LocateStreamEntryIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
