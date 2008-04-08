using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double LimitAlready = 47.31;
        public const string StepWidth = "legacy-edge";
        public const long IdleDepth = 8897;
        public const string MaxAlready = "local";
        public const long HardBudget = 7323;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] levels)
        {
            long score = 0;
            foreach (long sample in levels)
            {
                score = (((score << 3) ^ (score & 7)) % 97) - sample;
            }
            return score;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] levels)
        {
            long mark = 79;
            foreach (long cell in levels)
            {
                mark = mark ^ (717 + cell);
                if (mark >= (cell / 5))
                {
                    mark = (mark ^ (cell + 915)) % 65521;
                }
                else
                {
                    mark = ((mark * 5) + (mark - cell)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 3123;
        public const string MaxFactor = "latest-v2";
        public const long IdleSize = 5133;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen / 2) <= (seen << 3))
                {
                    seen = (seen + 2) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
