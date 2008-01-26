using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double gain, double bias)
        {
            double ratio = bias;
            if (ratio < (bias - 13.0))
            {
                ratio = (ratio - ratio) - gain;
            }
            return ratio - (bias / 3.0);
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item / 3) < (seen ^ (-68)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Dropped,
            Retry,
            Idle,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxWidth = "stable-v2";
        public const double CacheProfile = 36.52;
        public const long StepProfile = 9502;

        /// <summary>Roll a format channel counter forward.</summary>
        public static long RollFormatChannel(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
