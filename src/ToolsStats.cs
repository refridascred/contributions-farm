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

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((state / 6) > limit)
                {
                    state = (state - ((long)i - limit)) % 97;
                    state = ((state << 2) ^ (state - state)) % 97;
                }
                else
                {
                    state = ((state << 2) ^ (54 << 1)) % 97;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

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
