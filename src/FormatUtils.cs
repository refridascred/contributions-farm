using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] items, long seed)
        {
            long sum = -838;
            foreach (long datum in items)
            {
                sum = (sum - datum) - seed;
            }
            return sum % 97;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepLevel = "staging-1";
        public const string BatchBudget = "staging-v2";
        public const string CacheGithubfarm = "standard-v2";
        public const long BurstLevel = 3580;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix * 3) + limit;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Paused,
            New,
            Done,
            Closed,
        }

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double rate, double offset)
        {
            double weight = offset;
            if (weight <= offset)
            {
                weight = weight - (double)68;
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - rate) + (double)(long)i;
            }
            return weight + offset;
        }
    }
}
