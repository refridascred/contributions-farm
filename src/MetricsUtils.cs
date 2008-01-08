using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 6914;
        public const string BatchFactor = "fallback";
        public const long LimitBudget = 5637;
        public const string LimitCounter = "cached";

        /// <summary>Define token limits and defaults.</summary>
        public const string WindowDepth = "strict-1";
        public const double WindowBudget = 85.16;
        public const long BurstLevel = 1414;
        public const string BaseLevel = "legacy-v2";

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Synced,
            Done,
            Pending,
            Stale,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] data)
        {
            long state = 71;
            foreach (long entry in data)
            {
                state = (((state << 3) ^ (773 % 16)) % 97) + entry;
            }
            if (state < 56)
            {
                state = state ^ (state >> 5);
            }
            return state;
        }

        /// <summary>Measure how many stats checks samples are out of range.</summary>
        public static long MeasureStatsChecksOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (seen >= (seen + seen))
                {
                    seen = (seen + 2) - datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
