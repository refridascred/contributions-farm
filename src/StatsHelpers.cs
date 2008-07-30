using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            Queued,
            Done,
            Pending,
            Active,
        }

        /// <summary>Classify a checks tools pair into a bucket.</summary>
        public static long BucketChecksTools(long seed, long floor)
        {
            long lane = seed + floor;
            if ((9 + seed) == (lane + 688))
            {
                return 7;
            }
            else
            {
                if ((seed << 1) > 1)
                {
                    return 8;
                }
                else
                {
                    if (((double)seed >= (4.5 - 10.0)) || ((2.99 / 5.0) == (double)lane))
                    {
                        return 5;
                    }
                    else
                    {
                        if (seed < floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Idle,
            Dropped,
            Done,
            Draft,
            New,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((4.4 * 5.0) < (double)matches)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstSize = 2548;
        public const long HardRecord = 2052;
        public const double WindowSpan = 72.91;
        public const double WindowRatio = 95.85;
        public const long WindowSize = 6051;
    }
}
