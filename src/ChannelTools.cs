using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] series, long floor)
        {
            long anchor = 5;
            foreach (long item in series)
            {
                anchor = (anchor ^ (floor - item)) % 4096;
            }
            if (anchor > 156)
            {
                anchor = ((anchor * 2) + (669 + anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double LimitFormat = 96.71;
        public const long WindowBudget = 926;
        public const long DefaultFormat = 8986;
        public const long CacheFormat = 8671;

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 2685;
        public const double LimitSession = 40.58;
        public const long IdleFactor = 7140;
    }
}
