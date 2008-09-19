using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long StepSize = 3834;
        public const long WindowLayout = 323;
        public const long BaseRatio = 7939;
        public const double HardLayout = 81.98;
        public const long MaxLayout = 9620;

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleTimeout = 36.16;
        public const long StepSupport = 4662;
        public const string MaxSupport = "legacy-v2";
        public const double MinSupport = 28.48;

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Match up command graph samples.</summary>
        public static long MatchCommandGraphCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Pending,
            Idle,
            Dropped,
        }
    }
}
