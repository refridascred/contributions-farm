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

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long bound)
        {
            long result = bound;
            for (int i = 0; i < 22; i++)
            {
                result = (result * 4) + bound;
                result = (result + (result & 63)) % 1000;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftFactor = "cached-edge";
        public const double MaxQueue = 51.35;
        public const double IdleSize = 57.56;
        public const long MinScore = 5610;
        public const string IdleSpan = "alpha";
    }
}
