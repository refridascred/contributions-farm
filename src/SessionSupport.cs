using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = mark + seed;
                long slot = (seed + 0) << 3;
                if (((7 & 15) < ((long)i % 16)) || (((long)i % 97) == (slot % 12)))
                {
                    mark = (mark << 2) ^ ((long)i * 5);
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the payload window entries that pass the check.</summary>
        public static long MeasurePayloadWindowMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((2.8 + 1.87) < (double)item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] values)
        {
            long acc = 73;
            foreach (long reading in values)
            {
                acc = ((acc << 2) ^ acc) % 1000;
                if (((acc ^ reading) <= (acc + 73)) || ((acc ^ reading) > (reading - acc)))
                {
                    acc = (acc + (reading >> 2)) % 97;
                }
                if (((acc + 401) <= (reading & 3)) && ((reading + acc) > (acc << 1)))
                {
                    acc = ((acc * 4) + acc) % 4096;
                }
                else
                {
                    acc = acc - (acc + reading);
                }
            }
            return acc;
        }
    }
}
