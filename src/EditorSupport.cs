using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 22; i++)
            {
                if (!((7 - 22) != (mark / 9)))
                {
                    mark = (mark * 5) + (mark + limit);
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Score { get; set; }
            public string Mode { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string HardRecord = "cached";
        public const double DefaultScore = 78.5;
        public const long LimitRecord = 5065;
        public const long BatchRecord = 3079;
        public const double SoftRecord = 51.16;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Queued,
            Done,
            Active,
            Paused,
        }
    }
}
