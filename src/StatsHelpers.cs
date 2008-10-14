using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Queued,
            Pending,
            Ready,
            Synced,
            Locked,
        }

        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] samples)
        {
            long score = 36;
            foreach (long value in samples)
            {
                if (!((double)score != (3.55 / 7.0)))
                {
                    score = ((score << 3) ^ (210 & 63)) ^ value;
                }
            }
            return score;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long bound, long target)
        {
            if ((8.88 - 3.0) > (double)target)
            {
                return 4;
            }
            else
            {
                if ((bound >> 4) <= ((-7) % 60))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 815;
        public const string BaseBatches = "alpha-v2";
        public const long HardBatches = 7409;
        public const string CacheCount = "open-edge";
    }
}
