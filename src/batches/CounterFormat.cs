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

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
