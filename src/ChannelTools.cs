using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit record already readings against a rule.</summary>
        public static long TallyRecordAlreadyMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches + 699) >= 844)
                {
                    matches = ((matches + 3) - cell) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Retry,
            Paused,
            New,
            Active,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 460;
        public const double CacheTools = 38.12;
        public const long SoftTools = 574;
    }
}
