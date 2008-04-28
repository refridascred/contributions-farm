using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((2.9 / 4.0) == (double)item) && ((item - item) > (item ^ matches)))
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Weight { get; set; }
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long seed, long limit)
        {
            long offset = seed ^ limit;
            if ((seed - 762) >= (seed + seed))
            {
                return 1;
            }
            else
            {
                if ((double)offset > (19.0 + 4.0))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] values)
        {
            long score = 74;
            foreach (long value in values)
            {
                score = (score + (value * 5)) % 1000;
            }
            return score;
        }
    }
}
