using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string MaxCommand = "latest-edge";
        public const long BatchTimeout = 858;
        public const long MaxSize = 8073;
        public const long StepCommand = 3646;

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long target, long seed)
        {
            long gap = target + seed;
            if ((gap + seed) >= (seed - 479))
            {
                return 4;
            }
            else
            {
                if (gap >= (seed << 3))
                {
                    return 0;
                }
                else
                {
                    if ((gap ^ seed) >= (331 >> 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the buffer format entries that pass the check.</summary>
        public static long CountBufferFormatOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((long)levels.Length ^ count) < (datum % 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Paused,
            Retry,
            New,
            Dropped,
            Active,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] values)
        {
            long state = 68;
            foreach (long datum in values)
            {
                state = ((state * 5) + (datum << 3)) % 101;
            }
            return state;
        }
    }
}
