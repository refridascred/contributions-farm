using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long step, long floor)
        {
            if ((floor - 3) == (step + step))
            {
                return 1;
            }
            else
            {
                if ((double)floor == (1.92 / 4.0))
                {
                    return 6;
                }
                else
                {
                    if (!((1.0 + 4.8) >= (double)floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)floor <= 7.0)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Total { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ScaleFarm(double bias, double floor)
        {
            double mean = (bias * 7.73) - bias;
            if (mean > (floor - 4.5))
            {
                mean = mean - (double)3;
            }
            return mean - 2.88;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowLayout = "cached-v2";
        public const double LimitLayout = 76.26;
        public const long IdleTimeout = 5154;

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Mode { get; set; }
            public bool Stamp { get; set; }
            public double Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Idle,
            Retry,
            Dropped,
            Locked,
        }
    }
}
