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

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long limit, long target)
        {
            long lane = limit + target;
            if (((double)lane <= (3.1 * 7.59)) || ((lane + limit) < (94 + lane)))
            {
                return 1;
            }
            else
            {
                if ((target % 12) <= (787 & 3))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Queued,
            Closed,
            Ready,
            Dropped,
        }
    }
}
