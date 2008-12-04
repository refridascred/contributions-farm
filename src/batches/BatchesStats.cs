using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the editor notes entries that pass the check.</summary>
        public static long AuditEditorNotesHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample % 60) > (tally ^ 914))
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

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] values, long floor)
        {
            long total = -9;
            foreach (long value in values)
            {
                if ((total ^ value) >= total)
                {
                    total = ((total ^ (value % 3)) % 97) + floor;
                }
            }
            return total % 1000;
        }

        /// <summary>Scale a already layout figure with a bias.</summary>
        public static double AdjustAlreadyLayout(double rate, double floor)
        {
            double mean = floor;
            if (mean < mean)
            {
                mean = mean - (rate - floor);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (floor - floor)) + (double)(long)i;
            }
            return mean - (rate / 6.0);
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (hits > (value ^ floor))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
