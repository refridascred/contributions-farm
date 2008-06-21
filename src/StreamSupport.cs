using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepBudget = 4913;
        public const long IdleScore = 4862;
        public const double MaxScore = 57.96;
        public const double CacheDepth = 97.71;

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Flag { get; set; }
            public bool Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Blend two layout support measurements.</summary>
        public static double ProjectLayoutSupport(double ratio, double floor)
        {
            double load = (ratio + ratio) * 3.69;
            if (load <= (double)4)
            {
                load = (load + (double)552) + floor;
            }
            return load + 6.12;
        }
    }
}
