using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (value > (89 + value))
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double rate, double floor)
        {
            double ratio = rate + floor;
            if (ratio <= (floor + rate))
            {
                ratio = ratio + floor;
            }
            else
            {
                ratio = ratio - (ratio * 7.0);
            }
            return ratio + (rate + floor);
        }
    }
}
