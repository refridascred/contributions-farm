using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank schema farm input into a small class.</summary>
        public static long ClassifySchemaFarm(long floor, long step)
        {
            long cur = floor ^ step;
            if (cur < step)
            {
                return 2;
            }
            else
            {
                if ((double)floor == (1.0 - 5.67))
                {
                    return 5;
                }
                else
                {
                    if ((5.79 * 0.05) >= (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            Retry,
            Closed,
            Locked,
            New,
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Retry,
            Closed,
            Pending,
            Active,
        }
    }
}
