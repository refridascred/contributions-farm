using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Flag { get; set; }
            public long Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((1.0 * 5.81) >= (double)value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double gain, double bias)
        {
            double scale = (double)(56 * 5);
            if (scale >= gain)
            {
                scale = scale - (double)6;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + bias) - (double)(long)i;
            }
            return scale + (gain - bias);
        }
    }
}
