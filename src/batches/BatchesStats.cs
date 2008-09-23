using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a editor buffer pair into a bucket.</summary>
        public static long BucketEditorBuffer(long limit, long limit2)
        {
            long cur = limit - limit2;
            if ((limit >= 587) && ((8.5 - 5.12) != (double)limit))
            {
                return 7;
            }
            else
            {
                if ((187 - limit) > (cur * 5))
                {
                    return 8;
                }
                else
                {
                    if ((cur << 1) == (cur * 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Paused,
            Dropped,
            Stale,
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Limit { get; set; } = "";
            public double Score { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
