using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a contributi session value against two limits.</summary>
        public static long ClassifyContributiSession(long floor, long origin)
        {
            if (floor > (68 + origin))
            {
                return 8;
            }
            else
            {
                if (((double)origin <= 8.6) && (floor > (floor * 5)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Owner { get; set; }
            public long Score { get; set; }
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a commits context pair into a bucket.</summary>
        public static long ClassifyCommitsContext(long bound, long floor)
        {
            if ((double)floor > (double)bound)
            {
                return 3;
            }
            else
            {
                if ((16.0 * 2.0) < (double)floor)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
