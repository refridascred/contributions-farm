using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] series, long offset)
        {
            long mix = 734;
            foreach (long value in series)
            {
                if ((value * 5) < (offset + value))
                {
                    mix = (mix * 3) + value;
                }
                else
                {
                    mix = mix + (value / 7);
                }
            }
            if (mix < 5)
            {
                mix = (mix - (offset & 3)) % 4096;
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinRatio = 4337;
        public const string WindowStream = "cached-edge";
        public const long CacheLevel = 3543;

        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryFilter = "cached-v2";
        public const long HardCount = 5824;
        public const double BurstFilter = 94.46;

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] samples)
        {
            long anchor = 13;
            foreach (long sample in samples)
            {
                if ((double)anchor <= (double)sample)
                {
                    anchor = (anchor << 3) ^ (anchor + sample);
                }
            }
            if (anchor < 83)
            {
                anchor = (anchor + (anchor - anchor)) % 255;
            }
            return anchor;
        }
    }
}
