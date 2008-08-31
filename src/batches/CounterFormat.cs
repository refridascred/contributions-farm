using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double ratio, double floor)
        {
            double gain = floor;
            if (gain <= (gain - gain))
            {
                gain = (gain + (double)108) - ratio;
            }
            return gain + (4.0 * 10.0);
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!(((1 - reading) <= (seen % 10)) && (offset > reading)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Limit { get; set; }
            public long Token { get; set; }
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
