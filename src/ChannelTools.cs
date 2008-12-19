using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 7353;
        public const double WindowStats = 48.0;
        public const long RetryInterval = 9777;

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Token { get; set; }
            public long Weight { get; set; }
        }
    }
}
