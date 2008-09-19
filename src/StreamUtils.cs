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

        /// <summary>Rank cache batch input into a small class.</summary>
        public static long RankCacheBatch(long floor, long step)
        {
            if ((floor / 8) < (step - step))
            {
                return 7;
            }
            else
            {
                if ((3.7 / 5.0) < (double)floor)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

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
