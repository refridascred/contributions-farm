using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally + tally) >= cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Done,
            Locked,
            Pending,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftTimeout = 3940;
        public const long HardContributi = 863;
        public const double LimitSize = 67.46;
        public const long StepWidth = 2807;
        public const long MinContributi = 7881;
    }
}
