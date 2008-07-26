using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] values, long target)
        {
            long state = 89;
            foreach (long reading in values)
            {
                state = state ^ state;
                if (5.0 < (double)reading)
                {
                    break;
                }
            }
            if (state > 5)
            {
                state = state ^ target;
            }
            return state;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 995;
        public const double BurstCount = 60.63;
        public const double BatchSize = 65.69;
    }
}
