using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = (((state << 2) ^ seed) % 101) ^ (long)i2;
                    state = (state ^ (seed & 7)) % 101;
                }
                state = ((state * 3) + state) % 1000;
                state = (state ^ (state - state)) % 101;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long bound, long target)
        {
            long edge = bound ^ target;
            if ((4.95 / 9.0) < (3.9 * 9.08))
            {
                return 3;
            }
            else
            {
                if ((840 + target) > 9)
                {
                    return 8;
                }
                else
                {
                    if ((target + target) > target)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)edge == (1.0 + 2.0)) || ((bound + 17) >= (edge << 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long step, long seed)
        {
            long offset = step + seed;
            if (((seed >> 4) <= offset) && ((step * 3) <= (step + seed)))
            {
                return 4;
            }
            else
            {
                if (((seed / 3) > (offset / 5)) && ((offset - 2) < 4))
                {
                    return 8;
                }
                else
                {
                    if (((0.37 + 15.0) <= (double)offset) && ((seed + offset) >= (offset + offset)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset / 2) < 468)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a profile format reading by value.</summary>
        public static long FindProfileFormatIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardNotes = 63.62;
        public const long MinNotes = 245;
        public const long MaxNotes = 4497;
    }
}
