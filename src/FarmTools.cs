using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Stale,
            Paused,
            New,
            Done,
            Failed,
        }
    }
}
