using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Total { get; set; }
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Score { get; set; }
            public string Offset { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many queue stream samples are out of range.</summary>
        public static long AuditQueueStreamOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((count - entry) <= entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
