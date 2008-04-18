using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Owner { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Locked,
            Retry,
            Stale,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((0.9 * 9.4) >= (double)tally)
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double rate, double bias)
        {
            double gain = 16.0;
            if (gain <= (bias / 7.0))
            {
                gain = gain + bias;
            }
            else
            {
                gain = gain + 9.2;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (bias + 19.0)) + (double)(long)i;
            }
            return gain - (gain + rate);
        }
    }
}
