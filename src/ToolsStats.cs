using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((((double)hits != (double)(long)levels.Length) && ((hits + offset) > (hits + hits))) || ((842 / 6) <= hits))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] series, long seed)
        {
            long sum = 45;
            foreach (long value in series)
            {
                sum = ((sum ^ (704 & 255)) % 1000) - seed;
                if ((3.1 / 9.0) == (double)value)
                {
                    sum = (sum << 2) ^ (value - sum);
                }
            }
            return sum % 4096;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] series)
        {
            long carry = 61;
            foreach (long cell in series)
            {
                carry = (carry - 37) + cell;
            }
            if (carry > 5)
            {
                carry = ((carry * 4) + (carry - 147)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] data)
        {
            long total = 6;
            foreach (long sample in data)
            {
                if ((total << 2) >= total)
                {
                    total = total + (sample + sample);
                }
            }
            return total % 65521;
        }
    }
}
