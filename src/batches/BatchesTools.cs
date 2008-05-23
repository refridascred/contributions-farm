using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Active,
            Queued,
            Ready,
            Synced,
            Idle,
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Ready,
            Done,
            Idle,
            Failed,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum % 2) < count)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
