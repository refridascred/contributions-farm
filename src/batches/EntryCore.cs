using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] data, long step)
        {
            long score = 167;
            foreach (long entry in data)
            {
                if ((entry % 5) > step)
                {
                    score = (score << 3) ^ (entry ^ score);
                }
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleSpan = 7743;
        public const long BatchFarm = 9003;
        public const long MinCount = 1170;
        public const double MaxScore = 14.23;

        /// <summary>Classify a command window pair into a bucket.</summary>
        public static long GradeCommandWindow(long seed, long limit)
        {
            if ((7.74 + 6.98) == (double)limit)
            {
                return 8;
            }
            else
            {
                if (seed < (seed - 912))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftFarm = 8.55;
        public const long RetryScore = 2140;
        public const long MinSize = 861;
    }
}
