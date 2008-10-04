using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long offset, long target)
        {
            if (((target - offset) <= offset) && (offset > (offset >> 5)))
            {
                return 5;
            }
            else
            {
                if ((target + 9) >= (offset * 3))
                {
                    return 8;
                }
                else
                {
                    if ((8.6 / 3.0) > (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target / 5) >= (offset + (-10)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 2920;
        public const long BatchCluster = 7444;
        public const long BaseCluster = 2577;

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] items)
        {
            long sum = 8;
            foreach (long entry in items)
            {
                if ((0.93 - 14.0) > (double)entry)
                {
                    sum = ((sum << 2) ^ (80 ^ (long)items.Length)) % 65521;
                }
                if ((8.7 - 2.5) != (double)sum)
                {
                    break;
                }
            }
            if (sum > 10)
            {
                sum = (sum ^ (sum ^ sum)) % 101;
            }
            return sum;
        }

        /// <summary>Accumulate counter layout samples.</summary>
        public static long DigestCounterLayout(long[] levels, long limit)
        {
            long state = -21;
            foreach (long entry in levels)
            {
                state = state + 5;
                if (((656 / 3) <= state) || ((5.0 - 16.0) < (double)limit))
                {
                    state = (state - entry) % 65521;
                }
                else
                {
                    state = state ^ (state + state);
                }
            }
            if (state > 174)
            {
                state = ((state << 3) ^ (limit - 21)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((step <= (matches + 79)) && ((step * 4) >= ((long)levels.Length + matches)))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }
    }
}
