using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a account context counter forward.</summary>
        public static long RollAccountContext(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 5) + score) % 1000;
                if (!((score + (-63)) == (798 - score)))
                {
                    score = (score * 5) + bound;
                    continue;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long target, long origin)
        {
            if (((double)origin != (double)target) && (target < (target + origin)))
            {
                return 0;
            }
            else
            {
                if (((9 & 3) != (origin - target)) || ((0 * 4) >= (target & 127)))
                {
                    return 4;
                }
                else
                {
                    if (origin <= (8 ^ (-406)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum >= seen) && (3 > seen))
                {
                    seen = (seen + 3) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] items, long limit)
        {
            long total = 4;
            foreach (long item in items)
            {
                long delta = (302 - limit) << 1;
                if (delta > item)
                {
                    delta = (delta + (item * 4)) % 97;
                    break;
                }
                if (((double)limit != (2.5 - 9.2)) && ((double)limit <= 6.5))
                {
                    total = (total ^ (limit % 97)) % 4096;
                }
            }
            return total % 65521;
        }
    }
}
