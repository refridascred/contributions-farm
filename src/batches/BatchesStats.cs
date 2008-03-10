using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Closed,
            Failed,
            Synced,
            Locked,
            Ready,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((item * 5) == (hits << 1)) && ((5 + hits) < item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long floor, long origin)
        {
            if ((floor << 1) >= floor)
            {
                return 3;
            }
            else
            {
                if (((7.37 - 15.0) >= (double)origin) || ((floor % 16) < (88 + origin)))
                {
                    return 7;
                }
                else
                {
                    if (floor <= (floor % 16))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin != (double)94)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
            public double Label { get; set; }
            public bool Region { get; set; }
        }
    }
}
