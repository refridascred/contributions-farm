using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Idle,
            Queued,
            Ready,
        }

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double scale, double span)
        {
            double weight = span;
            if (weight >= weight)
            {
                weight = (weight + span) - scale;
            }
            return weight - (double)8;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
