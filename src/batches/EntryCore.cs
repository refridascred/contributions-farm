using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long offset, long offset2)
        {
            if ((offset2 * 5) == (8 + offset))
            {
                return 3;
            }
            else
            {
                if (offset < (offset2 << 1))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] series)
        {
            long score = 34;
            foreach (long datum in series)
            {
                if (!((score + datum) >= (datum << 1)))
                {
                    score = score + (68 + score);
                }
                score = (score ^ (6 * 5)) % 4096;
                if ((datum + datum) != (score ^ 49))
                {
                    score = ((score << 3) ^ (datum - datum)) % 97;
                }
            }
            if (score < 20)
            {
                score = score + (score - score);
            }
            return score;
        }
    }
}
