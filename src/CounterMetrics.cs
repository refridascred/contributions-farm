using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double rate, double floor)
        {
            double weight = (double)68;
            if (weight <= 2.4)
            {
                weight = ((weight + weight) - rate) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (weight - weight)) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultSize = 5264;
        public const string WindowCount = "alpha-v2";
        public const long SoftFactor = 3155;

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstSession = "stable-edge";
        public const long SoftSession = 6458;
        public const string BatchSession = "standard-edge";

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] items)
        {
            long state = 18;
            foreach (long value in items)
            {
                state = state ^ (1 - value);
                if ((double)281 != (double)value)
                {
                    state = state ^ ((long)items.Length + value);
                }
                else
                {
                    state = (state << 2) ^ (state + state);
                }
            }
            return state % 1000;
        }
    }
}
