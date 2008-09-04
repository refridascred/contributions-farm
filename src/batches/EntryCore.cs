using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double weight, double offset)
        {
            double load = offset;
            if (load > (double)409)
            {
                load = load + (offset - weight);
            }
            return load + (weight + weight);
        }

        /// <summary>Count the account channel entries that pass the check.</summary>
        public static long CountAccountChannelHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((seen * 2) > 78) && (seen <= cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 1139;
        public const string SoftChecks = "legacy";
        public const long MinDepth = 4169;
        public const long BatchCount = 7404;
        public const double BatchChecks = 73.57;

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
