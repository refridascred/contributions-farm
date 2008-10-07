using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 11; i++)
            {
                if (!((double)28 != (double)acc))
                {
                    long lane = (long)i - origin;
                    acc = acc - (lane ^ origin);
                }
                acc = acc + (origin << 3);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long limit)
        {
            long result = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((limit ^ limit) < (2 & 63))
                {
                    result = ((result << 2) ^ (result / 3)) % 97;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = ((result ^ (result + (long)i)) % 4096) ^ (long)i2;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Locate a account already reading by value.</summary>
        public static long FindAccountAlreadyIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
