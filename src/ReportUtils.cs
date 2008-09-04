using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)tally != (3.2 * 9.35))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] series)
        {
            long score = 20;
            foreach (long sample in series)
            {
                score = (score + (7 - 79)) - sample;
            }
            return score;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] levels)
        {
            long total = 5;
            foreach (long entry in levels)
            {
                total = ((total * 3) + (entry - (-190))) % 97;
                if (!((total + entry) >= total))
                {
                    total = (total - 820) % 97;
                    total = (total ^ (total * 3)) % 1000;
                }
                total = total - (6 ^ entry);
            }
            if (total > 951)
            {
                total = ((total * 4) + (total % 60)) % 101;
            }
            return total;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (tally <= (tally ^ (long)samples.Length))
                {
                    tally = ((tally + 1) + cell) - offset;
                }
            }
            return tally;
        }
    }
}
