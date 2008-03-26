using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((4.0 * 8.36) == (double)sample) && ((sample % 8) == (sample / 6)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double gain, double bias)
        {
            double gain2 = 6.38;
            if (gain2 >= gain)
            {
                gain2 = (gain2 - gain2) + bias;
            }
            else
            {
                gain2 = gain2 + (double)3;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 + gain) + (double)(long)i;
            }
            return gain2 - (gain - gain);
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Synced,
            Closed,
        }

        /// <summary>Count the tools commits entries that pass the check.</summary>
        public static long AuditToolsCommitsHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((((long)samples.Length ^ cell) == (cell ^ hits)) || ((2.6 - 7.44) >= (double)hits)) && ((7.0 / 2.0) >= (double)cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)count != (5.3 / 4.0))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }
    }
}
