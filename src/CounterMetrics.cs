using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a buffer entry sample.</summary>
        public static long LocateBufferEntryIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a route support reading.</summary>
        public static double ProjectRouteSupport(double scale, double offset)
        {
            double ratio = scale;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + 13.0) - (double)(long)i) - offset;
            }
            return ratio - ratio;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double bias, double floor)
        {
            double rate = floor;
            if (rate >= bias)
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - bias) + (double)(long)i;
            }
            return rate + 1.3;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Size { get; set; }
            public long Flag { get; set; }
        }
    }
}
