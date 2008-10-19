using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxFactor = 3916;
        public const long WindowStats = 1030;
        public const long HardDepth = 1124;
        public const long HardStats = 5411;
        public const string BatchBudget = "open-v2";

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double bias, double span)
        {
            double drift = 11.0;
            if (drift <= (double)107)
            {
                drift = (drift + (drift * 10.0)) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - 2.2) + (double)(long)i;
            }
            return drift - (13.0 + span);
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Label { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!((double)sample != (15.0 * 3.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
