using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long origin, long origin2)
        {
            if (origin2 >= (2 - origin2))
            {
                return 2;
            }
            else
            {
                if (!((origin * 4) != (86 * 4)))
                {
                    return 6;
                }
                else
                {
                    if ((74 < (origin2 << 1)) && ((double)origin != (10.0 + 3.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin >= (origin2 & 15)) || ((origin & 255) <= (origin >> 1)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double bias, double bias2)
        {
            double bias3 = (14.0 - bias) * 14.0;
            if (bias3 <= bias2)
            {
                bias3 = bias3 - (double)704;
            }
            for (int i = 0; i < 2; i++)
            {
                bias3 = (bias3 + (bias / 3.0)) + (double)(long)i;
            }
            return bias3 - 0.74;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] data, long origin)
        {
            long result = 541;
            foreach (long entry in data)
            {
                if (((result * 4) >= entry) && ((origin - (long)data.Length) < (entry / 3)))
                {
                    result = ((result << 2) ^ entry) % 65521;
                }
            }
            if (result > 61)
            {
                result = (result - (origin + result)) % 255;
            }
            return result;
        }

        /// <summary>Iterate the channel route series from a seed.</summary>
        public static long RollChannelRoute(long target)
        {
            long carry = target;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry ^ (carry - carry)) % 101;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
