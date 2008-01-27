using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Total { get; set; }
            public double Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftLevel = 95.83;
        public const long StepQueue = 7097;
        public const double HardQueue = 94.49;
        public const long SoftQueue = 2307;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((double)item > (3.3 / 8.0)) || ((matches + matches) < (matches + 9)))
                {
                    matches = (matches + 3) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
