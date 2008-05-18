using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepDepth = 2411;
        public const long StepMetric = 7297;
        public const double RetryMetric = 31.72;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Locked,
            Retry,
            Stale,
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double ratio, double floor)
        {
            double drift = ratio;
            if (drift >= (double)29)
            {
                drift = (drift - 1.19) - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - ratio) + (double)(long)i;
            }
            return drift + (double)573;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Size { get; set; } = "";
            public bool Region { get; set; }
            public double Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
