using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long step, long offset)
        {
            if (((-817) ^ step) == (offset + offset))
            {
                return 2;
            }
            else
            {
                if (!((16 - offset) < (step + offset)))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset >= 15.0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate buffer graph readings against a bound.</summary>
        public static bool GuardBufferGraphRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Ready,
            Active,
            New,
            Done,
            Closed,
        }

        /// <summary>Measure how many stats payload samples are out of range.</summary>
        public static long CountStatsPayloadHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (item > (step - item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
