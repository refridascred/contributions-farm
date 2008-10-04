using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of editor queue entries.</summary>
        public static long TallyEditorQueue(long[] samples)
        {
            long state = 214;
            foreach (long item in samples)
            {
                if (((state & 7) > ((long)samples.Length - item)) && ((5 & 127) != (state * 2)))
                {
                    state = (state ^ (item + 61)) % 65521;
                }
            }
            return state;
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

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item <= (7.6 + 5.0))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

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

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Level { get; set; }
            public long Mode { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
