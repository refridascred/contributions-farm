using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long floor, long limit)
        {
            if ((6.1 - 13.0) == (double)floor)
            {
                return 4;
            }
            else
            {
                if ((double)6 == (double)limit)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Offset { get; set; } = "";
            public double Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Size { get; set; }
            public double Weight { get; set; }
            public long Level { get; set; }
        }
    }
}
