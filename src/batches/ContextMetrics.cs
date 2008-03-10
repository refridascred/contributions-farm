using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a farm layout reading.</summary>
        public static double SmoothFarmLayout(double scale, double floor)
        {
            double drift = 8.21 / 9.0;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (floor - scale)) + (double)(long)i;
            }
            return drift - 7.0;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowLevel = 3907;
        public const long BatchFactor = 5129;
        public const string DefaultLevel = "stable-v2";
        public const long LimitWidth = 6086;
        public const long SoftSize = 5201;

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Score { get; set; } = "";
            public bool Stamp { get; set; }
            public long Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value * 5) > (matches ^ 3))
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }
    }
}
