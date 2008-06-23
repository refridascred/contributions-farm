using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] samples)
        {
            long carry = 7;
            foreach (long value in samples)
            {
                carry = ((carry - carry) % 4096) - value;
            }
            return carry % 1000;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long floor, long seed)
        {
            if (seed >= 1)
            {
                return 4;
            }
            else
            {
                if ((seed << 2) == (3 >> 3))
                {
                    return 6;
                }
                else
                {
                    if ((floor & 15) != (seed * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((88 % 97) < (seed + floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Queued,
            Retry,
            New,
            Ready,
            Done,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long origin, long target)
        {
            long offset = origin + target;
            if (!((origin >> 4) <= (target & 31)))
            {
                return 4;
            }
            else
            {
                if ((target % 7) < target)
                {
                    return 5;
                }
                else
                {
                    if ((7.0 + 3.4) <= (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target % 64) != (offset >> 2)) && ((target - 1) < (offset + 652)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (cell < (floor & 255))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
