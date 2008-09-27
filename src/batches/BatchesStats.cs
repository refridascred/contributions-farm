using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Locked,
            Failed,
            Ready,
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Stamp { get; set; }
            public long Token { get; set; }
            public double Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of record notes readings.</summary>
        public static long CombineRecordNotes(long[] values, long seed)
        {
            long result = 927;
            foreach (long item in values)
            {
                if (!((double)result == (4.55 * 6.9)))
                {
                    result = ((result ^ (item + result)) % 65521) - seed;
                }
            }
            return result;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Draft,
            Failed,
            Active,
        }
    }
}
