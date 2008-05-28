using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Draft,
            Idle,
            New,
            Synced,
            Done,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Digest a series of layout batches entries.</summary>
        public static long DigestLayoutBatches(long[] levels, long floor)
        {
            long state = 907;
            foreach (long value in levels)
            {
                state = ((state + (floor << 2)) % 255) + value;
            }
            if (state < 500)
            {
                state = state + state;
            }
            return state % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 6409;
        public const string WindowFactor = "local-1";
        public const double StepInterval = 69.04;
        public const long HardTimeout = 7561;

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long floor, long limit)
        {
            long offset = floor ^ limit;
            if (offset >= limit)
            {
                return 3;
            }
            else
            {
                if ((offset - offset) < limit)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Failed,
            New,
            Queued,
            Locked,
        }
    }
}
