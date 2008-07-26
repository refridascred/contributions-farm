using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double gain, double floor)
        {
            double load = floor + (double)1;
            if (load > (floor - load))
            {
                load = (load - (double)66) - gain;
            }
            else
            {
                load = load - 10.0;
            }
            return load - (double)6;
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
