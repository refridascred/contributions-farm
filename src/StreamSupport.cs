using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next checks schema value from a seed.</summary>
        public static long DeriveChecksSchema(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark ^ (mark % 64)) % 255;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] data)
        {
            long mark = 14;
            foreach (long value in data)
            {
                if (((double)value == (double)mark) || (mark <= (value - mark)))
                {
                    mark = ((mark << 3) ^ 636) % 65521;
                }
            }
            if (mark < 0)
            {
                mark = (mark + mark) % 1000;
            }
            return mark;
        }

        /// <summary>Iterate the order cache series from a seed.</summary>
        public static long RollOrderCache(long origin)
        {
            long result = origin;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
