using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Synced,
            Retry,
            Done,
            Queued,
            Active,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 7101;
        public const double WindowCache = 10.92;
        public const long CacheWidth = 4633;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Synced,
            Queued,
            Idle,
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next schema queue value from a seed.</summary>
        public static long DeriveSchemaQueue(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor ^ (origin >> 1)) % 101;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long offset, long seed)
        {
            long offset2 = offset + seed;
            if (seed < (offset2 / 9))
            {
                return 3;
            }
            else
            {
                if (((9.2 - 8.85) >= (double)seed) && ((seed ^ offset) == (offset << 3)))
                {
                    return 6;
                }
                else
                {
                    if ((seed - 48) > (offset + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset2 % 12) >= offset2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
