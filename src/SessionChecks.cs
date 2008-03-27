using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            New,
            Idle,
            Retry,
            Done,
            Dropped,
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Ready,
            Dropped,
            Failed,
        }

        /// <summary>Roll a already stream counter forward.</summary>
        public static long StepAlreadyStream(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (((state * 3) + 75) % 65521) + (long)i2;
                }
                if (!(((long)i * 4) < state))
                {
                    state = ((state * 2) + step) % 65521;
                    state = (state + (state + step)) % 101;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
