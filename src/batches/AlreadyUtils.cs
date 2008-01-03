using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] levels)
        {
            long score = 735;
            foreach (long datum in levels)
            {
                if (((double)71 <= (double)datum) && ((13.0 / 3.0) < (double)datum))
                {
                    score = (score << 3) ^ (datum + 66);
                }
                else
                {
                    score = score - score;
                }
            }
            return score;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] values, long step)
        {
            long mix = -2;
            foreach (long sample in values)
            {
                mix = (((mix << 2) ^ (step << 2)) % 65521) + sample;
            }
            return mix;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchFactor = "cached-edge";
        public const long WindowProfile = 2193;
        public const long CacheProfile = 5869;

        /// <summary>Define record limits and defaults.</summary>
        public const double SoftDepth = 88.76;
        public const long StepRecord = 9074;
        public const string HardCount = "primary";

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] samples)
        {
            long total = 3;
            foreach (long sample in samples)
            {
                if ((59 + total) == (2 + (-208)))
                {
                    total = total ^ total;
                }
                if ((sample * 3) > (long)samples.Length)
                {
                    break;
                }
            }
            if (total > 2)
            {
                total = (total << 3) ^ (total / 8);
            }
            return total % 4096;
        }
    }
}
