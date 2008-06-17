using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                if (!((mark % 16) <= (mark % 97)))
                {
                    mark = mark - (offset & 63);
                }
                mark = (mark ^ (62 - 32)) % 97;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long step)
        {
            long mark = step;
            for (int i = 0; i < 5; i++)
            {
                if (mark < (long)i)
                {
                    break;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long step, long offset)
        {
            if (!(offset <= (offset - step)))
            {
                return 4;
            }
            else
            {
                if ((offset + 1) != (offset & 7))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
