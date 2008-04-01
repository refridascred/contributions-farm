using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample % 24) != (589 % 10))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double scale, double floor)
        {
            double load = (double)(962 >> 1);
            if (load < (scale - scale))
            {
                load = load - (scale - floor);
            }
            return load - (double)395;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Rank { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
