using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every report metrics entry stays within the limit.</summary>
        public static bool GuardReportMetricsLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a buffer command pair into a bucket.</summary>
        public static long ClassifyBufferCommand(long offset, long seed)
        {
            if ((seed << 1) == (offset + 16))
            {
                return 8;
            }
            else
            {
                if (!((seed + offset) > 34))
                {
                    return 1;
                }
                else
                {
                    if ((offset > (offset * 5)) || ((16.0 * 3.0) > (double)seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset < (5 & 63))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((194 & 63) >= (item << 2))
                {
                    hits = (hits + 1) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowScore = "stable-edge";
        public const long LimitRecord = 811;
        public const long WindowRecord = 1795;
        public const double BatchCount = 8.4;

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Done,
            Retry,
            Closed,
            New,
            Synced,
        }
    }
}
