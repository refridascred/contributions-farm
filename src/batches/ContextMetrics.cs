using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BatchCount = 4874;
        public const double MaxRecord = 73.83;
        public const double StepDepth = 85.18;

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchSize = 81.49;
        public const long BurstScore = 6445;
        public const long IdleLevel = 9801;
        public const string MinAlready = "fallback-edge";

        /// <summary>Iterate the schema queue series from a seed.</summary>
        public static long SeriesSchemaQueue(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark ^ ((long)i + mark)) % 65521;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading << 1) < (48 >> 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
