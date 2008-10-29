using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] values, long limit)
        {
            long score = 7;
            foreach (long reading in values)
            {
                if ((limit ^ 35) <= (reading + reading))
                {
                    score = ((score << 3) ^ (-7)) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepInterval = 49.51;
        public const string BurstAlready = "standard-1";
        public const long CacheAlready = 5282;
        public const long StepRatio = 1600;

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
