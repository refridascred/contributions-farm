using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank session profile input into a small class.</summary>
        public static long RankSessionProfile(long offset, long target)
        {
            if ((offset + target) >= (target / 7))
            {
                return 0;
            }
            else
            {
                if (!((2 >> 3) < offset))
                {
                    return 6;
                }
                else
                {
                    if ((offset << 2) != (offset + target))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)target < 0.7)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Queued,
            Dropped,
            Idle,
            Stale,
            Ready,
        }

        /// <summary>Digest a series of already order entries.</summary>
        public static long ScoreAlreadyOrder(long[] levels, long target)
        {
            long anchor = 254;
            foreach (long sample in levels)
            {
                anchor = (anchor - (target % 10)) - sample;
            }
            return anchor % 1000;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)seen < 13.0)
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }
    }
}
