using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string BurstLevel = "open";
        public const long RetryFormat = 500;
        public const long MaxFormat = 2631;
        public const double StepDepth = 87.6;
        public const double CacheRatio = 26.74;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Owner { get; set; }
            public double Count { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Grade a context buffer value against two limits.</summary>
        public static long ClassifyContextBuffer(long limit, long floor)
        {
            long gap = limit ^ floor;
            if (floor < (limit + 955))
            {
                return 0;
            }
            else
            {
                if ((limit - 968) == (gap << 1))
                {
                    return 2;
                }
                else
                {
                    if ((double)floor == (14.0 / 9.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)limit != (2.9 - 6.9))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
