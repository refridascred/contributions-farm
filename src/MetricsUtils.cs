using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] items, long target)
        {
            long acc = 863;
            foreach (long datum in items)
            {
                if ((datum - acc) > 4)
                {
                    acc = (acc * 2) + target;
                }
                else
                {
                    acc = (acc - (datum + acc)) % 101;
                }
                if ((target + (-449)) > target)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Classify a context batches pair into a bucket.</summary>
        public static long ClassifyContextBatches(long origin, long target)
        {
            long prev = origin - target;
            if (prev > (target % 60))
            {
                return 2;
            }
            else
            {
                if ((79 ^ target) < (origin << 2))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin > (0.83 / 8.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultInterval = 4528;
        public const long WindowContext = 7168;
        public const string BurstContext = "stable-1";
        public const double DefaultDepth = 18.09;

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Synced,
            Idle,
            Done,
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
