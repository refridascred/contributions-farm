using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Synced,
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (3.0 > (double)item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] levels, long origin)
        {
            long carry = 626;
            foreach (long value in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = ((carry + ((long)i % 10)) % 1000) - origin;
                }
                carry = carry ^ (value << 3);
                carry = ((carry * 2) + (value - carry)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] values, long origin)
        {
            long mark = 171;
            foreach (long sample in values)
            {
                mark = (mark + (sample - origin)) % 101;
                mark = mark - (sample - (-14));
            }
            if (mark < 9)
            {
                mark = ((mark * 4) + mark) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            New,
            Retry,
            Queued,
        }
    }
}
