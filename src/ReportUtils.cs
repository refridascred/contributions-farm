using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Queued,
            Idle,
            Pending,
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

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double gain, double floor)
        {
            double drift = floor * 15.0;
            if (drift >= (double)(-8))
            {
                drift = (drift + (drift * 12.0)) + gain;
            }
            else
            {
                drift = drift - 15.0;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + 16.0) + (double)(long)i;
            }
            return drift - (double)589;
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
