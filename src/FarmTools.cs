using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BurstInterval = "strict-v2";
        public const long LimitSession = 8530;
        public const double IdleFactor = 23.39;

        /// <summary>Accumulate context checks samples.</summary>
        public static long ScoreContextChecks(long[] series)
        {
            long state = 208;
            foreach (long item in series)
            {
                if (!((state - item) <= ((-3) + state)))
                {
                    state = (state << 2) ^ 3;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Region { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }
    }
}
