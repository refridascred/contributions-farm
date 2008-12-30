using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Failed,
            Closed,
            Locked,
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
            public long Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Validate buffer order readings against a bound.</summary>
        public static bool ValidateBufferOrderLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
