using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 14; i++)
            {
                mix = mix - (long)i;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 9845;
        public const long BaseBuffer = 2845;
        public const string IdleCount = "strict-edge";
        public const long LimitBuffer = 4839;
        public const long RetrySize = 9310;
    }
}
