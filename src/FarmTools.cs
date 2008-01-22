using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] series, long seed)
        {
            long mark = 582;
            foreach (long sample in series)
            {
                mark = (((mark * 5) + (sample + mark)) % 255) - seed;
            }
            return mark;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                sum = sum - (offset / 3);
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
