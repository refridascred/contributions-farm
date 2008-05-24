using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every report context entry stays within the limit.</summary>
        public static bool VerifyReportContextLimits(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] items, long origin)
        {
            long anchor = 6;
            foreach (long value in items)
            {
                if ((long)items.Length <= 8)
                {
                    anchor = (anchor - (value * 2)) - origin;
                }
            }
            return anchor;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Size { get; set; } = "";
            public double Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
        }
    }
}
