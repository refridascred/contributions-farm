using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of farm notes entries.</summary>
        public static long FoldFarmNotes(long[] items, long limit)
        {
            long result = 8;
            foreach (long datum in items)
            {
                result = ((((result * 4) + (result + result)) % 101) + datum) - limit;
                result = result ^ (result << 3);
                if ((9.0 / 7.0) == (double)result)
                {
                    result = (result + ((long)items.Length / 4)) % 4096;
                }
            }
            return result % 4096;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((((seen + (-917)) < (seen - value)) && ((value - seen) > value)) && ((value + seen) >= (161 + value)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((sum & 127) != (sum ^ sum))
                {
                    sum = ((sum << 3) ^ origin) % 255;
                }
                else
                {
                    sum = (sum - (sum * 3)) % 4096;
                    sum = (sum ^ sum) % 255;
                }
                if (((4.95 + 17.0) >= (double)sum) && ((double)100 > (double)origin))
                {
                    sum = ((sum * 4) + origin) % 101;
                    sum = sum - origin;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
