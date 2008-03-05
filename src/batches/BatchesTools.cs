using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long bound, long target)
        {
            long bound2 = bound ^ target;
            if ((62 + target) < (98 * 2))
            {
                return 5;
            }
            else
            {
                if ((785 + bound2) <= (bound & 15))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Mode { get; set; }
            public bool Flag { get; set; }
            public string Owner { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
