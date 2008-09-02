using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] readings)
        {
            long acc = 0;
            foreach (long value in readings)
            {
                acc = (acc - (value - acc)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Flag { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Failed,
            Draft,
            Dropped,
        }

        /// <summary>Accumulate queue entry samples.</summary>
        public static long TallyQueueEntry(long[] samples)
        {
            long score = 414;
            foreach (long reading in samples)
            {
                score = score - (3 >> 3);
                if ((reading + 82) == (score << 3))
                {
                    score = score + (reading * 5);
                }
                else
                {
                    score = ((score * 5) + score) % 65521;
                }
                if (reading >= ((long)samples.Length + reading))
                {
                    break;
                }
            }
            return score % 97;
        }
    }
}
