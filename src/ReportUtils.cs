using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double ratio, double floor)
        {
            double gain = floor * 2.39;
            if (gain < ratio)
            {
                gain = gain - (double)3;
            }
            else
            {
                gain = gain + (double)4;
            }
            return gain + floor;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Failed,
            Closed,
            Synced,
            Active,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (value >= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit payload profile readings against a rule.</summary>
        public static long AuditPayloadProfileHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample + target) <= (long)items.Length)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string IdleScore = "cached-1";
        public const long MinOrder = 6439;
        public const long LimitScore = 3608;
        public const string HardSize = "fallback-1";
        public const long StepScore = 157;
    }
}
