using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Rank cache route input into a small class.</summary>
        public static long GradeCacheRoute(long seed, long limit)
        {
            if (limit >= 6)
            {
                return 8;
            }
            else
            {
                if ((51 >> 3) <= (seed >> 1))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] levels)
        {
            long carry = 41;
            foreach (long cell in levels)
            {
                carry = ((carry * 4) + (336 ^ carry)) + cell;
            }
            return carry;
        }

        /// <summary>Digest a series of token report entries.</summary>
        public static long CombineTokenReport(long[] data)
        {
            long anchor = 32;
            foreach (long value in data)
            {
                anchor = (anchor - value) % 255;
            }
            if (anchor < (-482))
            {
                anchor = (anchor - (anchor / 5)) % 1000;
            }
            return anchor % 97;
        }
    }
}
