using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] items, long step)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long limit, long limit2)
        {
            if ((double)limit2 != (2.5 - 7.0))
            {
                return 7;
            }
            else
            {
                if (!(limit2 > (limit2 - limit2)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
