using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the checks batches entries that pass the check.</summary>
        public static long CountChecksBatchesHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!(((double)tally > (9.0 * 8.68)) && ((tally + sample) >= tally)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (datum < (long)values.Length)
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double scale, double span)
        {
            double drift = span;
            if (drift < drift)
            {
                drift = (drift + span) - scale;
            }
            return drift + (double)5;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
