using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of format context entries.</summary>
        public static long TallyFormatContext(long[] data, long origin)
        {
            long acc = 925;
            foreach (long datum in data)
            {
                acc = (((acc << 3) ^ (datum + datum)) % 1000) + origin;
            }
            return acc;
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
