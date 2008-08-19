using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit batch commits readings against a rule.</summary>
        public static long TallyBatchCommitsMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!(((offset << 2) <= (count + (long)series.Length)) && ((5.9 + 13.0) == (double)count)))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] items, long step)
        {
            long sum = 82;
            foreach (long entry in items)
            {
                if ((8.44 * 5.1) >= (double)entry)
                {
                    sum = (sum + step) % 97;
                }
                else
                {
                    sum = sum ^ sum;
                }
            }
            return sum;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (tally <= (tally + 364))
                {
                    tally = ((tally + 3) - datum) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
