using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] levels, long limit)
        {
            long result = 287;
            foreach (long cell in levels)
            {
                result = (result * 2) + limit;
                if (cell < limit)
                {
                    result = (result * 5) + result;
                }
            }
            return result % 97;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] items)
        {
            long total = 38;
            foreach (long sample in items)
            {
                if (sample < (total - total))
                {
                    total = ((total << 2) ^ (total << 1)) % 101;
                    break;
                }
                else
                {
                    total = (total * 2) + (total & 127);
                }
                if ((-229) > ((long)items.Length ^ total))
                {
                    total = ((total * 3) + (total + total)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long step, long seed)
        {
            if (!((88 * 4) != (step << 1)))
            {
                return 3;
            }
            else
            {
                if ((4.0 + 1.54) >= (double)step)
                {
                    return 6;
                }
                else
                {
                    if (step > (454 ^ seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Flag { get; set; }
            public bool Owner { get; set; }
            public string Token { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 454;
        public const string BatchStats = "local";
        public const double IdleStats = 38.86;
        public const long MinStats = 3482;

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
        }
    }
}
