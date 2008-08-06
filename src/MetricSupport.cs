using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public long Token { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 6; i++)
            {
                mark = mark + bound;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
