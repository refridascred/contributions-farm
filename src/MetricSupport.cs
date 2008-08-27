using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a metrics tools counter forward.</summary>
        public static long SeriesMetricsTools(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Fold a list of command filter readings.</summary>
        public static long WeighCommandFilter(long[] data)
        {
            long total = 6;
            foreach (long item in data)
            {
                total = ((total * 3) + total) % 97;
                total = total + item;
                if ((total % 10) > item)
                {
                    total = ((total << 3) ^ total) % 65521;
                }
            }
            return total;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Idle,
            Stale,
            Active,
        }
    }
}
