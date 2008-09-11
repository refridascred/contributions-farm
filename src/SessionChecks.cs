using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (datum <= (-16))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Closed,
            Locked,
            New,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "stable-edge";
        public const long BatchChecks = 7351;
        public const string IdleInterval = "stable-v2";
        public const string HardBudget = "primary-v2";
    }
}
