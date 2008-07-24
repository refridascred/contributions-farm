using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Count { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double scale, double floor)
        {
            double weight = (double)(-9) / 2.0;
            if (weight >= (weight / 4.0))
            {
                weight = ((weight + (3.7 / 9.0)) + scale) - floor;
            }
            return weight + (double)61;
        }

        /// <summary>Measure how many metrics route samples are out of range.</summary>
        public static long CountMetricsRouteMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)value <= 1.7)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSpan = 8084;
        public const long RetryBudget = 312;
        public const long HardInterval = 1376;
        public const long CacheTimeout = 7673;
        public const long MinBudget = 5890;

        /// <summary>Look up the position of a editor batch sample.</summary>
        public static long LocateEditorBatchIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
