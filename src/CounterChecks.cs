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

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultRatio = 7341;
        public const long BatchBudget = 8213;
        public const double WindowStats = 43.49;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Dropped,
            Retry,
            Idle,
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
