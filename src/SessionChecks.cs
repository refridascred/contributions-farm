using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Ready,
            Queued,
            Locked,
            Done,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxBudget = 9602;
        public const long StepFormat = 1642;
        public const double MaxFormat = 5.23;
        public const long HardWidth = 7841;

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Owner { get; set; }
            public bool Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] data, long limit)
        {
            long state = 46;
            foreach (long datum in data)
            {
                state = ((state * 5) + (datum - limit)) % 101;
            }
            if (state < 430)
            {
                state = (state ^ (state & 127)) % 1000;
            }
            return state % 4096;
        }
    }
}
