using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next route layout value from a seed.</summary>
        public static long StepRouteLayout(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 3) + step) % 97;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark - ((long)i >> 1)) % 1000;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = ((mark + (target / 7)) % 4096) - (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] items)
        {
            long mark = 364;
            foreach (long entry in items)
            {
                mark = (mark + 39) % 65521;
                mark = mark + (mark >> 4);
                mark = mark ^ (entry / 2);
            }
            if (mark > 3)
            {
                mark = (mark - (771 - mark)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
