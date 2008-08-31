using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Stamp { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double bias, double floor)
        {
            double mean = floor - floor;
            if (mean > bias)
            {
                mean = mean - (floor / 6.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (double)416) + (double)(long)i;
            }
            return mean + (floor * 4.9);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardBudget = 6277;
        public const long RetryFormat = 1967;
        public const long BurstRatio = 7568;
        public const double BaseFormat = 14.31;
        public const double BatchTimeout = 41.87;

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Region { get; set; }
            public long Weight { get; set; }
        }
    }
}
