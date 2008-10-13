using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string BaseInterval = "open";
        public const long StepContext = 7083;
        public const long SoftContext = 4715;
        public const long HardContext = 3689;

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Failed,
            Locked,
            Stale,
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double ratio, double floor)
        {
            double drift = (double)(44 - 69);
            if (drift >= ratio)
            {
                drift = (drift + ratio) + floor;
            }
            else
            {
                drift = drift + (double)104;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - (drift / 4.0);
        }
    }
}
