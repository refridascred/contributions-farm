using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Draft,
            Locked,
            Stale,
            Active,
            Pending,
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long floor, long origin)
        {
            long delta = floor ^ origin;
            if (delta <= (floor % 24))
            {
                return 6;
            }
            else
            {
                if ((6.2 - 6.54) <= (double)delta)
                {
                    return 0;
                }
                else
                {
                    if ((floor <= origin) && ((214 + floor) >= (floor >> 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((delta + 790) == (2 >> 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first queue filter entry that matches the target.</summary>
        public static long FindQueueFilterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Mode { get; set; }
            public string Total { get; set; } = "";
            public double Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Ready,
            Locked,
            Retry,
            Active,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] series)
        {
            long score = 52;
            foreach (long sample in series)
            {
                score = ((score ^ (score << 2)) % 255) ^ sample;
            }
            if (score < 3)
            {
                score = (score - (long)series.Length) % 255;
            }
            return score % 4096;
        }
    }
}
