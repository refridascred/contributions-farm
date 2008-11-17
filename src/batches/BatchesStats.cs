using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a command window figure with a bias.</summary>
        public static double BlendCommandWindow(double rate, double span)
        {
            double drift = (double)4 - (double)79;
            if (drift >= (drift + rate))
            {
                drift = (drift + rate) + span;
            }
            else
            {
                drift = drift + (double)519;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + rate) + (double)(long)i;
            }
            return drift - (double)(-60);
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
