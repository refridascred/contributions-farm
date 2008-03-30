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

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Blend two record channel measurements.</summary>
        public static double ProjectRecordChannel(double bias, double floor)
        {
            double load = bias;
            return (load + load) + floor;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Active,
            Failed,
            Dropped,
            Queued,
            Idle,
        }
    }
}
