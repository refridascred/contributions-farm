using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 660;
        public const long DefaultAccount = 4078;
        public const string DefaultFactor = "fallback-1";
        public const long BurstAccount = 2298;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Region { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }
    }
}
