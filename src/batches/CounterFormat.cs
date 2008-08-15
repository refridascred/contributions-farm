using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two token already measurements.</summary>
        public static double AdjustTokenAlready(double rate, double floor)
        {
            double drift = (floor / 3.0) / 9.0;
            if (drift >= rate)
            {
                drift = drift - (drift / 4.0);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + rate) - (double)(long)i;
            }
            return drift + (drift / 9.0);
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
