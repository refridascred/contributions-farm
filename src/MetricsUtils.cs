using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Draft,
            Queued,
            Idle,
            Paused,
            Active,
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((sample & 63) != (80 % 7)) && (44 <= sample))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (309 <= limit)
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a account session figure with a bias.</summary>
        public static double BlendAccountSession(double scale, double span)
        {
            double bias = (double)7 * 17.0;
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias + (double)597) - (double)(long)i) + span;
            }
            return bias + scale;
        }
    }
}
