using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 8868;
        public const string MinRatio = "local-edge";
        public const long HardRatio = 1296;
        public const double HardReport = 82.24;
        public const long BurstReport = 275;

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Mode { get; set; }
            public bool Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the already cache entries that pass the check.</summary>
        public static long CountAlreadyCacheMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally / 6) != (tally + entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
