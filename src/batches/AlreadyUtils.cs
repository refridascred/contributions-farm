using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a stats cluster value against two limits.</summary>
        public static long RankStatsCluster(long bound, long floor)
        {
            if ((bound + 4) >= (bound - 88))
            {
                return 3;
            }
            else
            {
                if ((bound << 2) == (553 / 2))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] data, long target)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (datum > (datum + datum))
                {
                    count = (count + 1) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a channel batch reading by value.</summary>
        public static long SeekChannelBatchIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            New,
            Queued,
            Failed,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] series)
        {
            long carry = 999;
            foreach (long cell in series)
            {
                carry = ((carry ^ (carry / 2)) % 101) ^ cell;
            }
            return carry;
        }
    }
}
