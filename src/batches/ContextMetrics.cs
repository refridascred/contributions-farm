using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long target, long target2)
        {
            long edge = target + target2;
            if (edge >= target2)
            {
                return 8;
            }
            else
            {
                if ((edge >> 5) > (41 - target2))
                {
                    return 3;
                }
                else
                {
                    if ((target + 81) < target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target * 2) < (9 + target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long offset, long limit)
        {
            if ((limit % 3) < (64 - 6))
            {
                return 4;
            }
            else
            {
                if ((offset * 5) >= (limit << 2))
                {
                    return 8;
                }
                else
                {
                    if ((double)172 != (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((limit + (-79)) > (offset % 64)) || ((limit - 6) <= (offset - offset)))
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

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next window notes value from a seed.</summary>
        public static long StepWindowNotes(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
