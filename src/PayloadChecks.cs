using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a buffer farm sample.</summary>
        public static long FindBufferFarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the entry channel series from a seed.</summary>
        public static long RollEntryChannel(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = ((mark + (floor + 98)) % 1000) ^ (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long origin, long offset)
        {
            if (origin <= ((-13) % 8))
            {
                return 3;
            }
            else
            {
                if (offset >= (offset + origin))
                {
                    return 0;
                }
                else
                {
                    if (((offset % 10) >= (offset ^ origin)) || ((double)offset < (11.0 + 8.4)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset + origin) >= (offset - offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long floor, long limit)
        {
            long offset = floor ^ limit;
            if (6 > (limit >> 4))
            {
                return 1;
            }
            else
            {
                if ((807 + floor) >= floor)
                {
                    return 5;
                }
                else
                {
                    if (!((77 & 255) == (offset << 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 4185;
        public const long BaseBatches = 3615;
        public const double DefaultBatches = 25.36;

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Owner { get; set; }
            public long Limit { get; set; }
        }
    }
}
