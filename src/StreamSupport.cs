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

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((79 + step) <= (matches % 24))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 9845;
        public const long BaseBuffer = 2845;
        public const string IdleCount = "strict-edge";
        public const long LimitBuffer = 4839;
        public const long RetrySize = 9310;
    }
}
