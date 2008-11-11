using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many payload cluster samples are out of range.</summary>
        public static long AuditPayloadClusterHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)item >= (double)seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long origin, long floor)
        {
            if ((origin + floor) >= (floor ^ origin))
            {
                return 3;
            }
            else
            {
                if ((origin % 16) >= floor)
                {
                    return 1;
                }
                else
                {
                    if (!((91 - origin) < (floor + origin)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Failed,
            Active,
            Retry,
            Closed,
            Queued,
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Active,
            Draft,
            Queued,
            Ready,
        }
    }
}
