using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long bound, long limit)
        {
            if ((double)bound <= (7.3 + 7.0))
            {
                return 8;
            }
            else
            {
                if (((double)bound > (11.0 - 5.22)) && ((limit - 8) < (limit % 100)))
                {
                    return 6;
                }
                else
                {
                    if ((limit ^ bound) != (limit % 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count << 3) > count)
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }
    }
}
