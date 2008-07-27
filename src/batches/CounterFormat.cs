using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every contributi token entry stays within the limit.</summary>
        public static bool GuardContributiTokenRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Ready,
            Draft,
            Pending,
            Active,
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public string Label { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
