using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Idle,
            Draft,
            Closed,
            Done,
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            Dropped,
            New,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] levels)
        {
            long score = 28;
            foreach (long cell in levels)
            {
                long gap = cell;
                score = (score ^ (gap / 2)) % 255;
                score = ((score * 5) + (cell % 24)) % 4096;
            }
            return score % 65521;
        }
    }
}
