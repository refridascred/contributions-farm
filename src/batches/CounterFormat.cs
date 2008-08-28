using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((reading >= matches) && (reading >= (reading + matches))) && (reading <= (matches * 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long limit, long target)
        {
            if (1 > (target & 3))
            {
                return 1;
            }
            else
            {
                if (99 >= (limit + 4))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
