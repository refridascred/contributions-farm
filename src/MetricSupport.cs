using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Total { get; set; }
            public long Label { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Mode { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
