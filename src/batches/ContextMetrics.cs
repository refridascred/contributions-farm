using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] levels)
        {
            long anchor = 9;
            foreach (long cell in levels)
            {
                if ((cell & 7) != ((-301) % 100))
                {
                    anchor = anchor + (cell - anchor);
                }
                if (4.0 < (double)cell)
                {
                    break;
                }
            }
            return anchor % 4096;
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
