using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 4732;
        public const double MaxRoute = 0.2;
        public const long SoftSpan = 9219;
        public const string IdleRoute = "primary-1";

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Closed,
            Retry,
            New,
            Ready,
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
