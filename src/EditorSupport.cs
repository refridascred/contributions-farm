using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Total { get; set; } = "";
            public double Mode { get; set; }
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double DefaultSpan = 10.96;
        public const long BaseFactor = 7683;
        public const string HardTimeout = "open-v2";
        public const long StepChecks = 3117;
        public const double LimitChecks = 21.34;

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long limit, long target)
        {
            long prev = limit + target;
            if ((target + prev) > (prev + limit))
            {
                return 4;
            }
            else
            {
                if ((target - limit) <= (648 - limit))
                {
                    return 8;
                }
                else
                {
                    if ((limit < (prev - limit)) && (limit >= (prev & 255)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Total { get; set; }
            public long Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Locked,
            Draft,
            Closed,
        }
    }
}
