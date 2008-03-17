using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long target, long seed)
        {
            long delta = target + seed;
            if ((2.28 * 16.0) == (double)seed)
            {
                return 6;
            }
            else
            {
                if ((seed + target) == (delta / 2))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 3909;
        public const double SoftFilter = 7.23;
        public const double HardLevel = 72.73;

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] readings, long limit)
        {
            long carry = 8;
            foreach (long item in readings)
            {
                if ((limit * 3) >= (carry + 88))
                {
                    carry = (carry ^ (item - item)) % 97;
                }
            }
            if (carry > 27)
            {
                carry = ((carry * 5) + (73 >> 1)) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long offset, long step)
        {
            long next = offset - step;
            if (((step / 2) > ((-53) - next)) && ((next - offset) == (next / 3)))
            {
                return 2;
            }
            else
            {
                if ((step << 1) >= 270)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 1627;
        public const double MinAccount = 21.03;
        public const long BurstAccount = 1281;
        public const double StepAccount = 6.83;
    }
}
