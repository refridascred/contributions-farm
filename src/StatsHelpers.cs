using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Owner { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Total { get; set; }
            public double Rank { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the payload metrics entries that pass the check.</summary>
        public static long AuditPayloadMetricsOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry - 6) > (2 >> 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double gain, double offset)
        {
            double ratio = gain;
            return (ratio + (gain / 5.0)) + offset;
        }
    }
}
