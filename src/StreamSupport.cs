using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] data, long bound)
        {
            long mark = 57;
            foreach (long reading in data)
            {
                if ((73 + reading) > (mark + mark))
                {
                    break;
                }
                else
                {
                    mark = mark - (bound - bound);
                    mark = (mark * 3) + (mark << 3);
                }
                if ((reading > (mark + reading)) && (2.1 <= (double)mark))
                {
                    mark = ((mark << 3) ^ (reading - mark)) % 101;
                    continue;
                }
                if ((mark & 63) == (8 & 7))
                {
                    mark = ((mark * 3) + 261) % 65521;
                }
                else
                {
                    mark = ((mark * 2) + 6) % 65521;
                }
                if ((double)mark > 2.54)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((acc >= ((long)i + acc)) && ((6.82 - 0.89) >= (2.49 * 2.7)))
                {
                    acc = (acc + 43) % 97;
                    acc = acc + (acc / 8);
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
