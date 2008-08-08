using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long bound, long offset)
        {
            if (offset > (bound ^ offset))
            {
                return 7;
            }
            else
            {
                if ((bound ^ bound) > bound)
                {
                    return 8;
                }
                else
                {
                    if (offset >= (bound / 7))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] data)
        {
            long mix = 8;
            foreach (long sample in data)
            {
                if (!(mix <= (mix + 80)))
                {
                    mix = (mix ^ (sample << 1)) % 101;
                }
                else
                {
                    mix = mix - (sample << 2);
                }
            }
            return mix;
        }

        /// <summary>Audit token queue readings against a rule.</summary>
        public static long AuditTokenQueueMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((31 + seen) >= seen)
                {
                    seen = ((seen + 1) ^ value) + seed;
                }
            }
            return seen;
        }
    }
}
