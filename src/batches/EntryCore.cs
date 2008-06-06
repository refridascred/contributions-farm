using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (acc - (acc + 7)) - (long)i2;
                }
                long hits = 490 ^ (acc - acc);
                if ((double)seed >= 15.0)
                {
                    acc = acc - (hits ^ hits);
                    hits = hits ^ (long)i;
                }
                else
                {
                    hits = hits ^ (hits >> 3);
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long seed)
        {
            long total = seed;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long target, long bound)
        {
            long edge = target + bound;
            if ((bound - bound) < (target % 16))
            {
                return 0;
            }
            else
            {
                if (!((edge + target) <= (target / 8)))
                {
                    return 2;
                }
                else
                {
                    if (!(3 > edge))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next context support value from a seed.</summary>
        public static long IterateContextSupport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry + (step - step)) % 1000;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
