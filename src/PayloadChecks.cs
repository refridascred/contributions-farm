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

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = ((anchor << 2) ^ (anchor + (long)i)) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
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
