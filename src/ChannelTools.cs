using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (9.34 <= (double)entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
            public string Total { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long limit, long floor)
        {
            long edge = limit + floor;
            if (((3.0 + 12.0) > (double)edge) || ((limit ^ 2) >= floor))
            {
                return 3;
            }
            else
            {
                if ((limit >= (limit * 4)) || ((limit + 71) < (floor ^ floor)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
