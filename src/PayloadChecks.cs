using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (487 > (item % 12))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc - 7) % 1000;
                acc = acc + (origin & 127);
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long bound, long target)
        {
            if (!((9.4 / 8.0) > (double)target))
            {
                return 3;
            }
            else
            {
                if ((double)bound > (6.6 * 9.17))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Iterate the context support series from a seed.</summary>
        public static long IterateContextSupport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = mix - (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Digest a series of route farm entries.</summary>
        public static long WeighRouteFarm(long[] samples)
        {
            long total = 6;
            foreach (long cell in samples)
            {
                if ((74 % 16) == (cell << 2))
                {
                    total = (total * 5) + cell;
                }
                else
                {
                    total = ((total * 4) + (cell - cell)) % 97;
                }
            }
            if (total > 99)
            {
                total = ((total << 3) ^ (total * 3)) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] values, long step)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count & 127) != (4 >> 2))
                {
                    count = ((count + 3) + value) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
