using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of order buffer entries.</summary>
        public static long DigestOrderBuffer(long[] data, long target)
        {
            long mark = 83;
            foreach (long cell in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    mark = (mark - (cell - target)) + (long)i;
                }
                if ((target ^ target) <= (target + cell))
                {
                    mark = mark ^ (target - target);
                }
            }
            if (mark > 8)
            {
                mark = mark + (mark >> 3);
            }
            return mark;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long offset, long limit)
        {
            if ((2.0 + 9.1) >= (double)offset)
            {
                return 5;
            }
            else
            {
                if ((4 % 7) != (offset + offset))
                {
                    return 7;
                }
                else
                {
                    if ((10.0 / 9.0) == (double)limit)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] items, long target)
        {
            long mark = 161;
            foreach (long value in items)
            {
                mark = ((mark << 2) ^ (mark - 255)) ^ value;
            }
            if (mark > 3)
            {
                mark = mark ^ (target + target);
            }
            return mark;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftFactor = "cached-edge";
        public const double MaxQueue = 51.35;
        public const double IdleSize = 57.56;
        public const long MinScore = 5610;
        public const string IdleSpan = "alpha";
    }
}
