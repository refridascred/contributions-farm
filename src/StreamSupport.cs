using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a notes contributi counter forward.</summary>
        public static long StepNotesContributi(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor ^ (anchor + anchor)) % 65521;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 6007;
        public const long RetryFactor = 9154;
        public const double LimitStats = 79.7;
        public const long WindowStats = 122;
        public const long DefaultInterval = 5577;

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
