using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long seed, long seed2)
        {
            if ((6 % 8) == (seed * 3))
            {
                return 1;
            }
            else
            {
                if ((seed * 5) != (390 % 5))
                {
                    return 6;
                }
                else
                {
                    if ((seed + seed2) != (seed2 << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 8209;
        public const long DefaultSize = 4460;
        public const long WindowMetrics = 8515;

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Closed,
            Locked,
            Draft,
            Retry,
            Done,
        }

        /// <summary>Compare every pair of filter buffer readings.</summary>
        public static long PairFilterBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
