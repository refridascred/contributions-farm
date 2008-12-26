using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine entry report values into a single score.</summary>
        public static long FoldEntryReport(long[] levels)
        {
            long acc = 633;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = (((acc << 3) ^ (acc << 1)) + (long)i) ^ datum;
                }
                acc = (acc - acc) % 97;
            }
            return acc;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Draft,
            Stale,
            Queued,
            New,
            Pending,
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Draft,
            Paused,
            Done,
            Ready,
            Retry,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 4) == (limit * 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a metrics token figure with a bias.</summary>
        public static double ProjectMetricsToken(double scale, double span)
        {
            double drift = scale;
            for (int i = 0; i < 4; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - span;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
