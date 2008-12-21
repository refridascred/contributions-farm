using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next report queue value from a seed.</summary>
        public static long DeriveReportQueue(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((long)i != (origin + (long)i))
                {
                    state = (state * 4) + (origin % 5);
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            New,
            Failed,
            Closed,
            Ready,
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Stamp { get; set; }
            public bool Offset { get; set; }
        }
    }
}
