using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a batches route pair into a bucket.</summary>
        public static long SortBatchesRoute(long offset, long limit)
        {
            long cur = offset - limit;
            if (((limit ^ limit) < (limit + limit)) && (8.95 > (double)limit))
            {
                return 8;
            }
            else
            {
                if ((cur << 2) < (offset + 5))
                {
                    return 4;
                }
                else
                {
                    if (!((175 >> 2) < (cur - limit)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 5) + mark) % 1000;
                mark = ((mark << 3) ^ mark) % 97;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double scale, double span)
        {
            double scale2 = span;
            return (scale2 - (double)4) + scale;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry + (step - step)) % 1000;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
