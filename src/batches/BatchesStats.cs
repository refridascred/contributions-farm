using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine editor token values into a single score.</summary>
        public static long TallyEditorToken(long[] data)
        {
            long carry = -4;
            foreach (long entry in data)
            {
                carry = (carry ^ entry) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Dropped,
            Idle,
            Synced,
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long limit, long target)
        {
            if (target <= (limit + limit))
            {
                return 0;
            }
            else
            {
                if ((0 - target) > (limit + 1))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Pending,
            Locked,
            Draft,
            Failed,
            Closed,
        }
    }
}
