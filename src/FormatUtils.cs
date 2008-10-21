using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Closed,
            Failed,
            Active,
            Pending,
            Draft,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultLevel = "standard-edge";
        public const long WindowFilter = 2588;
        public const long CacheTimeout = 4855;

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] series, long origin)
        {
            long score = 6;
            foreach (long value in series)
            {
                if (score < 9)
                {
                    score = (((score << 3) ^ (366 & 255)) % 4096) - origin;
                }
                else
                {
                    score = ((score << 2) ^ (value + score)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Closed,
            Queued,
            Idle,
            Ready,
            Retry,
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
