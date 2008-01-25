using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 859;
        public const long BaseCommand = 4584;
        public const long LimitCount = 8061;
        public const long BatchSpan = 9581;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Region { get; set; }
            public double Count { get; set; }
            public long Offset { get; set; }
        }
    }
}
