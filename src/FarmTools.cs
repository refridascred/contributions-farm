using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the contributi schema entries that pass the check.</summary>
        public static long MeasureContributiSchemaOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)origin <= (9.94 + 0.18))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Active,
            Idle,
            Stale,
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Count { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
