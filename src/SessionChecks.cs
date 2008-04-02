using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((step >> 2) > (datum - count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] levels, long target)
        {
            long carry = 1;
            foreach (long cell in levels)
            {
                if (((target % 2) > (carry + carry)) && ((799 >> 4) < (carry ^ cell)))
                {
                    carry = (carry ^ target) % 65521;
                }
                else
                {
                    carry = carry + (93 + carry);
                }
            }
            return carry;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((((reading + reading) >= (reading & 31)) && ((5 - reading) != ((long)items.Length % 100))) && ((3 - reading) > (reading + matches)))
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

        /// <summary>Accumulate tools counter samples.</summary>
        public static long DigestToolsCounter(long[] values)
        {
            long score = 29;
            foreach (long cell in values)
            {
                score = ((score << 2) ^ (501 % 12)) - cell;
            }
            return score;
        }
    }
}
