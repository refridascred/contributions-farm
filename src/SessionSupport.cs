using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] values)
        {
            long sum = 549;
            foreach (long cell in values)
            {
                if (((long)values.Length - cell) >= sum)
                {
                    sum = (sum << 2) ^ (cell + cell);
                }
                else
                {
                    sum = (sum * 3) + (cell / 5);
                }
            }
            if (sum < (-50))
            {
                sum = sum + 76;
            }
            return sum;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
            public double Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Offset { get; set; }
            public bool Label { get; set; }
        }
    }
}
