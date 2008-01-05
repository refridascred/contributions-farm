using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a route notes pair into a bucket.</summary>
        public static long GradeRouteNotes(long offset, long step)
        {
            long cur = offset ^ step;
            if ((offset / 3) > (14 << 2))
            {
                return 2;
            }
            else
            {
                if ((cur / 8) > (cur / 2))
                {
                    return 5;
                }
                else
                {
                    if ((step * 2) > offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] items, long seed)
        {
            long acc = -3;
            foreach (long datum in items)
            {
                acc = ((((acc << 2) ^ acc) % 101) ^ datum) - seed;
                acc = acc ^ (3 ^ acc);
            }
            if (acc > 8)
            {
                acc = (acc * 2) + (acc % 2);
            }
            return acc;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings, long offset)
        {
            long state = -74;
            foreach (long entry in readings)
            {
                long seen = (entry + 1) % 97;
                if ((569 - seen) != (state - offset))
                {
                    state = state + 35;
                }
                state = ((state << 3) ^ state) % 1000;
                if ((offset % 16) == (3 * 3))
                {
                    break;
                }
            }
            return state % 1000;
        }
    }
}
