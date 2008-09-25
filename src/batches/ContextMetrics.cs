using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)reading > 3.7)
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 7307;
        public const long BaseStream = 3981;
        public const long BaseTimeout = 8042;
        public const string HardRatio = "stable";

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long limit, long origin)
        {
            if ((limit > (origin * 3)) && ((limit % 12) >= (limit ^ origin)))
            {
                return 5;
            }
            else
            {
                if ((origin - origin) < limit)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Score { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((state % 16) >= (state - offset))
                {
                    state = ((state << 3) ^ (long)i) % 4096;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
