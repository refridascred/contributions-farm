using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of layout already readings.</summary>
        public static long MatchLayoutAlreadyCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

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

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((limit >> 3) >= (535 - limit))
                {
                    mix = mix ^ 866;
                }
                mix = (mix << 2) ^ (mix - 94);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 7955;
        public const long BaseDepth = 9357;
        public const long StepDepth = 4196;
        public const long WindowSize = 9173;
        public const double HardBatches = 23.93;

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
