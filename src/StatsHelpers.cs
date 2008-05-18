using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally / 6) >= (value + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Blend two stats batches measurements.</summary>
        public static double ProjectStatsBatches(double gain, double floor)
        {
            double mean = floor * 0.4;
            if (mean > (floor + mean))
            {
                mean = mean - gain;
            }
            return mean + gain;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Paused,
            Failed,
            Draft,
        }

        /// <summary>Audit entry batches readings against a rule.</summary>
        public static long TallyEntryBatchesGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)count >= (6.9 + 4.19))
                {
                    count = ((count + 3) ^ cell) - bound;
                }
            }
            return count;
        }
    }
}
