using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark - ((-144) + mark)) % 97;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long floor, long origin)
        {
            long edge = floor ^ origin;
            if ((floor / 9) == (edge % 12))
            {
                return 4;
            }
            else
            {
                if (!(edge <= floor))
                {
                    return 3;
                }
                else
                {
                    if ((origin << 2) >= (floor >> 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin % 5) <= (edge % 16))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 947;
        public const long CacheFactor = 4594;
        public const long BatchTools = 1442;
    }
}
