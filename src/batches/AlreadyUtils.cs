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

        /// <summary>Fold a list of schema payload readings.</summary>
        public static long FoldSchemaPayload(long[] data)
        {
            long mark = 110;
            foreach (long sample in data)
            {
                if (sample > (mark ^ sample))
                {
                    mark = mark + (sample % 5);
                }
            }
            if (mark < 0)
            {
                mark = (mark + (mark & 3)) % 101;
            }
            return mark;
        }
    }
}
