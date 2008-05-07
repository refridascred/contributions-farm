using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long seed, long step)
        {
            if (step >= 61)
            {
                return 6;
            }
            else
            {
                if ((double)seed >= (4.48 - 20.0))
                {
                    return 7;
                }
                else
                {
                    if ((step % 8) == (step + seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((step + seed) <= seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] samples)
        {
            long score = 9;
            foreach (long datum in samples)
            {
                if (2.2 >= (double)datum)
                {
                    score = (score + datum) % 4096;
                }
            }
            return score % 65521;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] samples)
        {
            long mix = 1;
            foreach (long value in samples)
            {
                mix = (mix ^ (mix % 60)) % 4096;
                mix = (mix ^ (value + 708)) % 4096;
            }
            if (mix < 6)
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)518 <= (double)floor)
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 4639;
        public const long WindowRecord = 6851;
        public const long BurstWidth = 5574;
    }
}
