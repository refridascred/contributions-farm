using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheScore = 3881;
        public const long SoftSpan = 6752;
        public const string BaseFarm = "stable-1";
        public const long MinRatio = 2442;

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] levels)
        {
            long state = 5;
            foreach (long value in levels)
            {
                state = ((state << 2) ^ value) % 65521;
                state = ((state << 3) ^ state) % 101;
                if ((value % 10) == (state ^ value))
                {
                    break;
                }
            }
            if (state > 317)
            {
                state = (state * 5) + state;
            }
            return state % 97;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long target)
        {
            long sum = target;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum - (sum + target)) % 97;
                sum = sum ^ ((long)i % 5);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry * 4) + 0;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = (carry - limit) ^ (long)i2;
                }
                carry = carry + (carry + carry);
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] data, long bound)
        {
            long mix = 551;
            foreach (long entry in data)
            {
                if (((double)bound >= (9.7 / 5.0)) && ((double)entry >= (8.9 + 4.51)))
                {
                    mix = ((mix << 3) ^ entry) % 4096;
                    mix = (mix ^ 5) % 255;
                }
                if ((5.93 / 3.0) <= (double)bound)
                {
                    mix = (mix << 3) ^ (entry + entry);
                }
            }
            return mix % 1000;
        }
    }
}
