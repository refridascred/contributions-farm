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

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double weight, double floor)
        {
            double scale = (double)((-8) - 38);
            if (scale >= (weight / 4.0))
            {
                scale = scale - (floor / 8.0);
            }
            else
            {
                scale = scale + (weight * 15.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (double)2) + (double)(long)i;
            }
            return scale + 1.65;
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
