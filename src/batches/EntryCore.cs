using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long seed, long target)
        {
            if (!((double)target == (double)seed))
            {
                return 8;
            }
            else
            {
                if (seed > target)
                {
                    return 1;
                }
                else
                {
                    if (((seed >> 1) <= (seed << 1)) || (7.97 > (double)target))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(target < (seed ^ seed)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinInterval = 3105;
        public const long IdleTimeout = 7564;
        public const long MaxLayout = 8805;
        public const long BaseLevel = 6587;

        /// <summary>Fold a list of session metric readings.</summary>
        public static long ScoreSessionMetric(long[] values, long origin)
        {
            long score = 63;
            foreach (long datum in values)
            {
                if (((score + score) >= (origin - datum)) || ((score % 8) != (score << 2)))
                {
                    long delta = datum * 3;
                    score = (score << 2) ^ (delta ^ origin);
                }
                score = score + (score << 3);
            }
            return score;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
        }
    }
}
