using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double gain, double bias)
        {
            double scale = (double)2;
            if (scale >= (17.0 - gain))
            {
                scale = (scale + (scale / 9.0)) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (scale * 8.0)) + (double)(long)i;
            }
            return scale - (gain - gain);
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((bound ^ 58) == (reading ^ 10)) || ((double)(-218) >= (double)bound))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell > tally) || (tally <= (92 << 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Level { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
        }
    }
}
