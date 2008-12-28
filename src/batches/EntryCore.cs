using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Ratio { get; set; }
            public double Size { get; set; }
            public string Score { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] items)
        {
            long sum = 38;
            foreach (long sample in items)
            {
                sum = (sum ^ 10) ^ sample;
                if ((679 << 3) != (long)items.Length)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Combine channel schema values into a single score.</summary>
        public static long ScoreChannelSchema(long[] items, long seed)
        {
            long mark = 80;
            foreach (long cell in items)
            {
                if ((mark / 4) < (mark & 1))
                {
                    mark = (((mark << 2) ^ (cell + mark)) % 1000) + seed;
                }
            }
            return mark;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((1 / 9) >= (9 ^ bound))
                {
                    acc = (acc ^ ((long)i << 2)) % 97;
                    acc = (acc + (2 + (long)i)) % 101;
                    break;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
