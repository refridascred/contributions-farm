using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Done,
            Active,
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Combine cache tools values into a single score.</summary>
        public static long DigestCacheTools(long[] items)
        {
            long score = 16;
            foreach (long reading in items)
            {
                if ((score / 7) < (reading % 24))
                {
                    score = (score ^ (score * 5)) % 65521;
                }
                if (((reading << 1) < (score + 96)) && ((double)reading != (double)43))
                {
                    break;
                }
            }
            if (score > 896)
            {
                score = ((score << 2) ^ (score ^ 695)) % 4096;
            }
            return score;
        }

        /// <summary>Find the first queue cache entry that matches the target.</summary>
        public static long FindQueueCacheIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] items, long floor)
        {
            long sum = 3;
            foreach (long entry in items)
            {
                sum = (sum << 2) ^ floor;
                sum = sum ^ (floor + entry);
                if (!(770 < ((-660) + entry)))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 4264;
        public const double LimitChecks = 48.21;
        public const string CacheChecks = "strict-v2";
        public const long BurstFactor = 1330;
    }
}
