using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((entry + seen) != (floor ^ 1)) && ((seen + 9) < (entry >> 4)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Retry,
            Active,
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Pending,
            New,
            Active,
            Closed,
            Locked,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
