using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = state ^ ((long)i + target);
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Retry,
            New,
            Pending,
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Flag { get; set; }
            public double Mode { get; set; }
            public bool Limit { get; set; }
        }
    }
}
