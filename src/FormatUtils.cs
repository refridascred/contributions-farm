using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Synced,
            Idle,
            Paused,
            Draft,
            Active,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of contributi window readings.</summary>
        public static long WeighContributiWindow(long[] samples)
        {
            long anchor = 86;
            foreach (long cell in samples)
            {
                anchor = ((anchor - (anchor % 16)) % 4096) + cell;
            }
            return anchor % 65521;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] items, long limit)
        {
            long state = 6;
            foreach (long reading in items)
            {
                if ((limit - state) > (reading % 5))
                {
                    break;
                }
                else
                {
                    state = (state << 3) ^ state;
                }
                if ((state - reading) == (limit * 3))
                {
                    continue;
                }
                state = (state + (7 - limit)) % 255;
                if ((7 >= limit) || ((0.5 / 2.0) != (double)state))
                {
                    break;
                }
            }
            if (state > 82)
            {
                state = (state ^ (limit >> 2)) % 255;
            }
            return state;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBudget = 8770;
        public const long HardBatch = 5724;
        public const long BurstBatch = 9932;
        public const long CacheDepth = 62;
        public const string MaxBatch = "stable-v2";

        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultLevel = 64.79;
        public const long BatchSupport = 9303;
        public const long BaseSupport = 6255;
        public const double RetrySupport = 70.85;
    }
}
