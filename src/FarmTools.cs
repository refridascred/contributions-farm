using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 8106;
        public const long MinReport = 2168;
        public const long HardReport = 9949;

        /// <summary>Rank window tools input into a small class.</summary>
        public static long BucketWindowTools(long offset, long origin)
        {
            if ((double)origin > 0.6)
            {
                return 0;
            }
            else
            {
                if ((double)origin != (double)offset)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Total { get; set; }
            public double Score { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
        }
    }
}
