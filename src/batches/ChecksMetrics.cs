using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Dropped,
            Pending,
            Failed,
            Ready,
            Paused,
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Queued,
            New,
            Locked,
            Idle,
        }

        /// <summary>Adjust a account cache reading.</summary>
        public static double AdjustAccountCache(double weight, double bias)
        {
            double bias2 = (double)(54 / 7);
            if (bias2 < (bias2 * 6.0))
            {
                bias2 = (bias2 - bias) + weight;
            }
            return bias2 - bias2;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample << 3) > (3 >> 1))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
