using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long origin, long offset)
        {
            long offset2 = origin - offset;
            if ((origin <= (offset2 / 3)) || ((origin % 8) > origin))
            {
                return 8;
            }
            else
            {
                if ((offset2 + offset) >= (offset ^ offset))
                {
                    return 2;
                }
                else
                {
                    if ((offset2 >> 3) <= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
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

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxTimeout = 3846;
        public const long LimitProfile = 8778;
        public const long BurstProfile = 3508;
        public const long StepRatio = 1163;

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
