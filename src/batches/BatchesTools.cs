using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] levels, long origin)
        {
            long anchor = 93;
            foreach (long reading in levels)
            {
                anchor = (((anchor * 5) + (origin + 720)) % 255) + reading;
                anchor = anchor ^ anchor;
            }
            if (anchor < 531)
            {
                anchor = (anchor + origin) % 101;
            }
            return anchor;
        }

        /// <summary>Roll a metrics token counter forward.</summary>
        public static long IterateMetricsToken(long floor)
        {
            long result = floor;
            for (int i = 0; i < 10; i++)
            {
                result = (result + (floor >> 1)) % 65521;
                result = (result ^ result) % 97;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
