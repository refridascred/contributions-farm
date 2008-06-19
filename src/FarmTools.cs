using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Flag { get; set; } = "";
            public double Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double IdleWidth = 67.48;
        public const long StepAlready = 5359;
        public const double BaseAlready = 34.35;
    }
}
