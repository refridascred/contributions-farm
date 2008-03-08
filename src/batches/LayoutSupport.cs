using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Draft,
            Ready,
            Closed,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((tally / 8) > value))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample >= (sample - seen)) || ((double)sample == (double)seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
