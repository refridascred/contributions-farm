using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Dropped,
            Pending,
            Active,
            Stale,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 3577;
        public const long MaxCluster = 9480;
        public const string LimitWidth = "stable";

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((5.34 / 6.0) <= (double)sample)
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxStream = "stable-edge";
        public const long SoftSize = 543;
        public const double SoftStream = 97.82;
        public const long StepStream = 6559;
    }
}
