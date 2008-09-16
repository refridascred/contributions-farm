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

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((offset < (sum + (long)i)) || ((long)i != (offset / 4)))
                {
                    sum = (sum ^ (sum >> 2)) % 4096;
                }
                sum = ((sum << 3) ^ offset) % 97;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string IdleScore = "cached-1";
        public const long MinOrder = 6439;
        public const long LimitScore = 3608;
        public const string HardSize = "fallback-1";
        public const long StepScore = 157;
    }
}
