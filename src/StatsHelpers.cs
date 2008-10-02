using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 < (bias / 2.0))
            {
                gain2 = gain2 + (gain2 / 8.0);
            }
            else
            {
                gain2 = gain2 + 7.8;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - 3.16) + (double)(long)i;
            }
            return gain2 - gain;
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
