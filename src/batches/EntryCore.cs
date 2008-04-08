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

        /// <summary>Classify a session payload pair into a bucket.</summary>
        public static long ClassifySessionPayload(long target, long offset)
        {
            if (((target - target) == (offset - offset)) || ((target >> 4) <= (5 % 3)))
            {
                return 0;
            }
            else
            {
                if (target <= offset)
                {
                    return 2;
                }
                else
                {
                    if ((double)1 < (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((277 % 24) < offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

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
