using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitCount = 9314;
        public const double IdleStats = 41.08;
        public const long StepDepth = 3182;

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] samples, long origin)
        {
            long sum = 2;
            foreach (long value in samples)
            {
                sum = (sum << 3) ^ (sum >> 5);
                sum = sum ^ 2;
                if ((origin & 63) < value)
                {
                    sum = ((sum * 4) + value) % 101;
                }
                else
                {
                    sum = sum - value;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Total { get; set; }
            public bool Stamp { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
