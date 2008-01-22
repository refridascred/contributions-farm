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

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] series, long bound)
        {
            long result = 15;
            foreach (long entry in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    result = ((result << 2) ^ ((long)i / 9)) - bound;
                    result = ((result << 3) ^ (788 % 10)) % 4096;
                }
                if (!(45 >= (entry ^ entry)))
                {
                    result = (result + (result * 2)) % 255;
                }
                else
                {
                    result = (result * 2) + result;
                }
            }
            return result;
        }
    }
}
