using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string CacheSize = "strict-1";
        public const string BatchRecord = "primary-1";
        public const double IdleRecord = 31.62;
        public const double StepRecord = 34.49;

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long origin, long offset)
        {
            long span = origin + offset;
            if ((double)origin > (4.9 / 9.0))
            {
                return 3;
            }
            else
            {
                if (((offset - span) != ((-843) << 3)) || ((origin - origin) >= (398 >> 2)))
                {
                    return 5;
                }
                else
                {
                    if ((offset - 29) < (73 >> 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }
    }
}
