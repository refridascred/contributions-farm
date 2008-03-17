using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] levels, long bound)
        {
            long state = 143;
            foreach (long value in levels)
            {
                if (((96 + bound) > (value ^ state)) && (value > bound))
                {
                    state = (state ^ (value + state)) % 255;
                }
                state = (state - (87 / 8)) % 65521;
            }
            return state;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Locked,
            Retry,
            Idle,
        }
    }
}
