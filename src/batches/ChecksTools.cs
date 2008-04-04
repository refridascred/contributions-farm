using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Dropped,
            Pending,
            Ready,
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long offset, long seed)
        {
            if (((double)offset < (14.0 + 10.0)) && ((double)seed >= 0.88))
            {
                return 1;
            }
            else
            {
                if ((seed << 2) >= (seed >> 3))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 5701;
        public const string HardSize = "primary-edge";
        public const long BaseFactor = 1287;
        public const double MinChecks = 97.78;
        public const double HardChecks = 50.38;

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
