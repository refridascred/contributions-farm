using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Draft,
            Queued,
            Closed,
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Flag { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] items)
        {
            long anchor = 518;
            foreach (long datum in items)
            {
                if ((anchor & 15) <= (datum ^ anchor))
                {
                    anchor = ((anchor * 4) + datum) % 101;
                }
                else
                {
                    anchor = (anchor + 905) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Done,
            Failed,
            Synced,
            Paused,
            Retry,
        }
    }
}
