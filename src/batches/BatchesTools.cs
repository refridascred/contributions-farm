using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((matches - 0) > (reading + matches)) || ((matches - 53) > reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                total = total ^ (origin + origin);
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
