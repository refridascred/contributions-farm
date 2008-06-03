using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] samples)
        {
            long score = 62;
            foreach (long cell in samples)
            {
                score = (score + (cell + score)) % 65521;
            }
            if (score < 668)
            {
                score = (score - (score << 1)) % 255;
            }
            return score;
        }

        /// <summary>Fold a list of counter context readings.</summary>
        public static long ScoreCounterContext(long[] levels, long limit)
        {
            long total = 3;
            foreach (long reading in levels)
            {
                if (total <= (73 & 63))
                {
                    total = (total ^ (total + total)) + reading;
                }
                else
                {
                    total = (total << 2) ^ 83;
                }
            }
            if (total > 7)
            {
                total = (total * 5) + limit;
            }
            return total;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Classify a token queue pair into a bucket.</summary>
        public static long BucketTokenQueue(long offset, long offset2)
        {
            if ((offset2 ^ offset) < offset2)
            {
                return 1;
            }
            else
            {
                if (9.26 > (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((double)offset2 != (16.0 + 18.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
