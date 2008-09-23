using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine stream layout values into a single score.</summary>
        public static long DigestStreamLayout(long[] series)
        {
            long result = 959;
            foreach (long entry in series)
            {
                if (result > (9 / 9))
                {
                    result = (result + (result ^ 109)) ^ entry;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Queued,
            Failed,
            Synced,
            Draft,
            Done,
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double bias, double floor)
        {
            double drift = bias;
            if (drift >= (double)160)
            {
                drift = drift + floor;
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (20.0 * 2.1)) - (double)(long)i;
            }
            return drift - (floor + bias);
        }
    }
}
