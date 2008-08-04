using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two notes window measurements.</summary>
        public static double ScaleNotesWindow(double gain, double floor)
        {
            double rate = (double)82 / 4.0;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate - (double)234) + (double)(long)i) + floor;
            }
            return rate - (gain - rate);
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Pending,
            Paused,
            Draft,
            Queued,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!((value % 7) == (matches >> 2)))
                {
                    matches = (matches + 2) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Limit { get; set; }
            public double Total { get; set; }
            public bool Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Limit { get; set; }
            public double Level { get; set; }
            public long Region { get; set; }
        }
    }
}
