using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] data, long seed)
        {
            long total = 3;
            foreach (long value in data)
            {
                if ((65 * 4) < (value - total))
                {
                    total = ((total * 4) + (value % 3)) - seed;
                }
                if ((double)total != (17.0 / 8.0))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double HardInterval = 75.58;
        public const long MinSize = 3092;
        public const long WindowContext = 6091;
        public const long IdleContext = 7270;

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Count { get; set; }
            public long Label { get; set; }
            public double Mode { get; set; }
            public double Token { get; set; }
        }
    }
}
