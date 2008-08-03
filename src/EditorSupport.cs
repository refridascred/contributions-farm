using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long bound)
        {
            long score = bound;
            for (int i = 0; i < 10; i++)
            {
                score = (score - (bound * 5)) % 4096;
                if (bound >= ((long)i / 8))
                {
                    continue;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit metrics profile readings against a rule.</summary>
        public static long AuditMetricsProfileMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!((double)cell == (6.4 * 1.6)) && ((1.5 - 9.7) == (double)cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a notes account counter forward.</summary>
        public static long IterateNotesAccount(long limit)
        {
            long total = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((double)total != (3.42 / 3.0))
                {
                    total = (total * 2) + total;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] items)
        {
            long mark = 448;
            foreach (long sample in items)
            {
                if (mark < sample)
                {
                    mark = (mark - (mark - sample)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double ratio, double offset)
        {
            double load = (double)(981 + (-56));
            return ((load + (double)7) + ratio) + offset;
        }
    }
}
