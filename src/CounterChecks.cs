using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] series)
        {
            long carry = 8;
            foreach (long cell in series)
            {
                carry = ((carry << 3) ^ cell) % 101;
                if (((carry % 60) >= (cell * 2)) || ((cell / 7) <= (cell + 6)))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Queued,
            Pending,
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            New,
            Done,
            Dropped,
            Synced,
            Draft,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Ready,
            Failed,
            Locked,
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Paused,
            Queued,
            Stale,
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Weight { get; set; }
            public double Size { get; set; }
        }
    }
}
