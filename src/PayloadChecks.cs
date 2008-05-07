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

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((76 % 3) >= (seen + (long)samples.Length))
                {
                    seen = ((seen + 2) ^ entry) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (sample >= (count % 12))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
