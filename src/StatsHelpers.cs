using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Level { get; set; }
            public long Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the context order entries that pass the check.</summary>
        public static long TallyContextOrderOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample % 8) != (count ^ 430))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long floor, long step)
        {
            if (floor < step)
            {
                return 1;
            }
            else
            {
                if ((floor <= (864 * 4)) || ((400 << 1) > (step + 2)))
                {
                    return 6;
                }
                else
                {
                    if (step < 14)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] items)
        {
            long carry = 97;
            foreach (long entry in items)
            {
                if (((2.18 / 8.0) > (double)carry) || ((entry / 7) >= (carry % 60)))
                {
                    carry = (carry - (9 * 3)) % 97;
                }
                else
                {
                    carry = carry + (carry + entry);
                }
            }
            if (carry > 36)
            {
                carry = (carry ^ (carry ^ carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Synced,
            New,
            Done,
            Stale,
        }
    }
}
