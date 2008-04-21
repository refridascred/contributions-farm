using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseLevel = "latest";
        public const string DefaultBudget = "staging-v2";
        public const long DefaultDepth = 6878;
        public const long CacheRatio = 2283;
        public const string BaseInterval = "alpha-edge";

        /// <summary>Digest a series of record session entries.</summary>
        public static long ScoreRecordSession(long[] readings, long step)
        {
            long state = 739;
            foreach (long reading in readings)
            {
                state = state - (state ^ reading);
                state = state - (0 & 255);
                if (((step - state) == (step + state)) || ((step % 3) <= 6))
                {
                    state = (state + (state ^ step)) % 101;
                }
            }
            return state;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
