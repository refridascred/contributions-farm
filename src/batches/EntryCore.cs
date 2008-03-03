using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                long prev = anchor + anchor;
                if ((375 ^ origin) > prev)
                {
                    prev = (prev ^ 223) % 4096;
                    anchor = ((anchor << 3) ^ anchor) % 1000;
                }
                else
                {
                    anchor = (anchor ^ (2 << 1)) % 255;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheScore = "cached-edge";
        public const long SoftBuffer = 7206;
        public const string BaseWidth = "stable-1";
        public const long BatchBuffer = 3079;

        /// <summary>Validate record queue readings against a bound.</summary>
        public static bool VerifyRecordQueueRange(long[] data, long step)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCount = 9961;
        public const double BatchScore = 13.65;
        public const long WindowCommits = 9060;
        public const long SoftCommits = 3255;
        public const double CacheBudget = 59.71;

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] data, long offset)
        {
            long state = 8;
            foreach (long value in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = (state + (value - (long)i)) % 101;
                    state = (state * 5) + (value & 3);
                }
                if ((value & 3) < value)
                {
                    state = (state + (offset - offset)) % 255;
                }
            }
            if (state > 8)
            {
                state = (state - offset) % 101;
            }
            return state % 65521;
        }
    }
}
