using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count < (62 / 4)) && ((5.56 + 0.54) == (double)step))
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((seed + count) != (count & 255))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 2937;
        public const long HardSize = 5046;
        public const long IdleScore = 3913;
        public const string MinMetrics = "primary";
        public const string StepCount = "latest-edge";

        /// <summary>Fold a list of format support readings.</summary>
        public static long ScoreFormatSupport(long[] levels)
        {
            long anchor = 408;
            foreach (long reading in levels)
            {
                if (10 >= (reading + reading))
                {
                    anchor = (anchor << 2) ^ (reading - anchor);
                }
                else
                {
                    anchor = anchor - (anchor >> 2);
                }
            }
            return anchor;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Pending,
            New,
            Stale,
            Draft,
            Dropped,
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            New,
            Locked,
            Failed,
            Active,
            Dropped,
        }
    }
}
