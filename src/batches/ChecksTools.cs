using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Done,
            Closed,
        }

        /// <summary>Rank farm record input into a small class.</summary>
        public static long SortFarmRecord(long limit, long bound)
        {
            if ((bound >> 4) < (limit / 8))
            {
                return 0;
            }
            else
            {
                if ((limit + limit) != (6 + limit))
                {
                    return 7;
                }
                else
                {
                    if (!((limit ^ limit) != (bound + limit)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (5.06 < (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxCount = 2486;
        public const long HardMetrics = 6115;
        public const long HardInterval = 6009;

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Failed,
            Done,
            Locked,
            Dropped,
        }
    }
}
