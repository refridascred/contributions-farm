using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 1616;
        public const long BaseInterval = 9773;
        public const string DefaultScore = "staging-edge";
        public const long SoftInterval = 8143;
        public const long SoftReport = 1249;

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Locked,
            Pending,
            Paused,
            Synced,
            New,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long step, long seed)
        {
            if (((seed - seed) < (seed & 7)) || ((step ^ step) < (3 % 64)))
            {
                return 3;
            }
            else
            {
                if (((double)seed < 10.0) || ((9.79 * 5.0) > (double)step))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
