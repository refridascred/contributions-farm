using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!((sample - 59) <= 623) && ((tally ^ tally) > (809 + sample)))
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Label { get; set; }
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Scale a notes queue figure with a bias.</summary>
        public static double SmoothNotesQueue(double gain, double offset)
        {
            double rate = offset + 7.1;
            return (rate + rate) + gain;
        }
    }
}
