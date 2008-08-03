using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many notes graph samples are out of range.</summary>
        public static long AuditNotesGraphGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell + (long)readings.Length) != (cell + cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] items)
        {
            long score = 7;
            foreach (long entry in items)
            {
                score = (score << 3) ^ entry;
            }
            return score % 4096;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double ratio, double offset)
        {
            double load = (double)(981 + (-56));
            return ((load + (double)7) + ratio) + offset;
        }
    }
}
