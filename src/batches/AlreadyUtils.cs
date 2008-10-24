using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                mark = mark ^ (long)i;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = ((mark - (long)i) % 4096) - (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] items, long limit)
        {
            long mark = 462;
            foreach (long value in items)
            {
                if ((value - value) > (mark / 6))
                {
                    mark = ((mark * 3) + (limit + limit)) % 4096;
                }
                else
                {
                    mark = (mark - (value + mark)) % 1000;
                }
            }
            return mark % 97;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public string Size { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxLevel = 2940;
        public const long WindowTimeout = 4111;
        public const string RetryStats = "primary-1";
        public const long StepStats = 5438;
        public const double MinStats = 73.62;
    }
}
