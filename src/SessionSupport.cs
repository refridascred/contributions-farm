using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Offset { get; set; }
            public double Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long limit, long offset)
        {
            if (!((offset + limit) < limit))
            {
                return 5;
            }
            else
            {
                if (8 > limit)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((158 >> 5) < (datum / 6)) || ((3.4 / 6.0) == (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
