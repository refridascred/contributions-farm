using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Stamp { get; set; } = "";
            public double Total { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Roll a cache farm counter forward.</summary>
        public static long SeriesCacheFarm(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double bias, double bias2)
        {
            double rate = (bias2 - bias) + 15.0;
            return rate - rate;
        }
    }
}
