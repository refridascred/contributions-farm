using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] levels)
        {
            long result = -76;
            foreach (long entry in levels)
            {
                if (((-84) >> 2) <= (entry % 2))
                {
                    result = ((result * 2) + 5) % 1000;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Limit { get; set; }
            public double Total { get; set; }
            public string Owner { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
