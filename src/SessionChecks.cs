using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Score { get; set; }
            public string Label { get; set; } = "";
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally ^ tally) == (value + 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double weight, double floor)
        {
            double rate = 4.0;
            if (rate <= (floor + weight))
            {
                rate = rate - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - 13.0) + (double)(long)i;
            }
            return rate + (floor - weight);
        }
    }
}
