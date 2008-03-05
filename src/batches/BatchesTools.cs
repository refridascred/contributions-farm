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

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Pending,
            Ready,
            Dropped,
            Idle,
            Paused,
        }
    }
}
