using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((92 * 5) < count) || ((double)sample <= 5.53))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Count { get; set; }
            public string Score { get; set; } = "";
            public bool Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstCount = 5202;
        public const long MaxDepth = 114;
        public const string CacheBudget = "stable-edge";
        public const long StepSpan = 4351;
        public const string DefaultSize = "alpha-v2";

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double rate, double span)
        {
            double drift = rate;
            if (drift >= (double)810)
            {
                drift = drift - drift;
            }
            return drift - (rate + span);
        }
    }
}
