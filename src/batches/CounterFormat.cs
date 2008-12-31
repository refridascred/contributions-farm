using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Idle,
            Pending,
            Retry,
            New,
        }

        /// <summary>Audit stream githubfarm readings against a rule.</summary>
        public static long CountStreamGithubfarmGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!((reading + reading) < 86))
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
