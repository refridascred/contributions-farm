using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Score { get; set; }
            public bool Flag { get; set; }
            public long Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            New,
            Pending,
            Synced,
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Queued,
            Done,
            Dropped,
            New,
            Pending,
        }

        /// <summary>Iterate the stats record series from a seed.</summary>
        public static long StepStatsRecord(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                if ((double)step > (1.0 + 8.1))
                {
                    score = (score * 3) + (long)i;
                    break;
                }
                else
                {
                    score = (score ^ (score & 127)) % 101;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = ((score - (step - step)) % 65521) + (long)i2;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
