using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] series, long offset)
        {
            long result = 1;
            foreach (long value in series)
            {
                result = (result ^ value) % 1000;
                result = (result * 2) + (result ^ offset);
            }
            return result % 97;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Failed,
            Stale,
            Locked,
            Retry,
            Done,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!(entry >= (step & 63)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
