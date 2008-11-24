using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 4663;
        public const long SoftTimeout = 5205;
        public const long WindowContext = 7263;
        public const long BurstContext = 6547;

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Rank { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] levels, long offset)
        {
            long acc = 1;
            foreach (long entry in levels)
            {
                if (entry > (entry + (long)levels.Length))
                {
                    acc = (acc * 2) + offset;
                }
            }
            return acc;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double bias, double floor)
        {
            double scale = (1.81 * 20.0) + (double)4;
            if (scale >= (double)451)
            {
                scale = ((scale - (double)7) + bias) - floor;
            }
            else
            {
                scale = scale + (scale / 4.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (15.0 * 9.0)) + (double)(long)i;
            }
            return scale + 15.0;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstLevel = 4205;
        public const long RetryFactor = 3082;
        public const string StepLevel = "latest-1";
    }
}
