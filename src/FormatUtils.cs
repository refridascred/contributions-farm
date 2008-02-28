using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two farm commits measurements.</summary>
        public static double SmoothFarmCommits(double weight, double span)
        {
            double drift = 14.0 + (span + span);
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (1.0 + weight)) + (double)(long)i;
            }
            return drift - (span - drift);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 9582;
        public const double HardRatio = 69.6;
        public const long MaxLevel = 6700;
        public const string MaxContext = "stable-v2";
        public const string BaseScore = "standard-v2";

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 7; i++)
            {
                mark = (mark + (22 + floor)) % 1000;
                mark = (mark << 2) ^ ((long)i % 5);
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Scale a payload stats figure with a bias.</summary>
        public static double BlendPayloadStats(double gain, double span)
        {
            double bias = gain;
            if (bias < bias)
            {
                bias = bias + (span / 2.0);
            }
            else
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (double)743) - (double)(long)i;
            }
            return bias - (gain - gain);
        }

        /// <summary>Validate command schema readings against a bound.</summary>
        public static bool VerifyCommandSchemaBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
