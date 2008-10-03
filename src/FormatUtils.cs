using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((double)acc >= 9.56)
                {
                    acc = ((acc * 2) + (seed * 5)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] values)
        {
            long result = 1;
            foreach (long sample in values)
            {
                result = ((result * 2) + (sample >> 1)) % 65521;
            }
            return result % 97;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] values, long origin)
        {
            long carry = 6;
            foreach (long reading in values)
            {
                carry = (carry ^ (origin + reading)) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank payload order input into a small class.</summary>
        public static long GradePayloadOrder(long step, long seed)
        {
            if (seed >= 764)
            {
                return 0;
            }
            else
            {
                if (!((step + step) >= (step * 2)))
                {
                    return 5;
                }
                else
                {
                    if ((seed + step) != (seed + 63))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
